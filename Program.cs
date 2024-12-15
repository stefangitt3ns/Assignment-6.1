using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1
{
    
    enum House
    {
        Colonial,
        Ranch,
        Townhouse,
        Victorian,
        Modern,
        Bungalow
    }
    class HouseNode  // the node class set up to keep track of the data in the node and the directions to the next node. 
    {
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public House Type { get; set; }  // The new type I defined above
        public HouseNode NextNode;

        public HouseNode(int houseNumber, string address, House type)
        {
            this.HouseNumber = houseNumber;
            this.Address = address;
            this.Type = type;
            NextNode = null; 
        }
    }

    class HouseList   // the linked list set up to manage the nodes and keep track of the root node. 
    {
        private HouseNode head;

        public HouseList()
        {
            head = null;   // the root node of the list
        }

        // the method to add new houses/nodes to the list 

        public void AddHouse(int houseNumber, string address, House type)
        {
            HouseNode newHouse = new HouseNode(houseNumber, address, type);
            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                HouseNode current = head;
                while (current.NextNode != null)
                {
                    current = current.NextNode;
                }
                current.NextNode = newHouse;
            }

        }

        // Method to searxh for a house by its number
        public void SearchHouse(int houseNumber)
        {
            HouseNode current = head;
            while (current != null)
            {
                if (current.HouseNumber == houseNumber)
                {
                    Console.WriteLine($"House Number: {current.HouseNumber}");
                    Console.WriteLine($"Address: {current.Address}");
                    Console.WriteLine($"House Type: {current.Type}");
                    return; 
                }
                current = current.NextNode; 
            }
            Console.WriteLine("House not found");
        }





    }
















    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }

}
