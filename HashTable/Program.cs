using HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(6);
            hash.Add("1", "to");
            hash.Add("2", "be");
            hash.Add("3", "or");
            hash.Add("4", "not");
            hash.Add("5", "to");
            hash.Add("6", "be");
            Console.WriteLine("Displaying elements of hashtable before removing node");
            hash.Display();
            hash.Remove("4");
            Console.WriteLine("Displaying elements of hashtable after removing node");
            hash.Display();


            Console.ReadLine();
        }
    }
}