using System;

namespace FactorialAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number: ");
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);
            
            if(isNumber == true)
            {
                if(number>0 && number < 30)
                {
                    //calculate the factorial
                    //5! = 5*4*3*2*1
                    int factorial = 1;
                    for ( int x=1; x<=number; x++)
                    {
                        factorial = factorial * x;
                    }
                    Console.WriteLine("Factorial of the number: " + Convert.ToString(factorial));
                }
                else
                {
                    Console.WriteLine("Input is out of bounds");
                }
            }
        }
    }
}
