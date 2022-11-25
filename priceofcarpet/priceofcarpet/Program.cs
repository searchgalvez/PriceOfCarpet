using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priceofcarpet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // && is only true if both sides are true
            // t && t = true
            // t && f = false
            // f && f = false
            // f && t = false

            // or(||) is only false when both sides are false
            // t || t = t
            // t|| f = t
            // f || f = t
            // f || t = t
            // f || f = f


            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the movie rating?");
            char rating = char.Parse(Console.ReadLine());
            if (age <= 12 && rating == 'G'|| age >= 55)
            {
                Console.WriteLine("Discount applies");
            }
            else
            {
                Console.WriteLine("No discount applies");
            }



        }
    }
}
