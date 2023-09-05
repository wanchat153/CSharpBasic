using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Output
            Console.WriteLine("Hello World");

            //Input Name and Print Name
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();

            //Convert data
            Console.WriteLine("Enter Age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi " + name+ " Age " + age);

            //Input end
            Console.ReadLine();
        }
    }
}
