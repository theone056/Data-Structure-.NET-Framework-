using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_.NET_Framework_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProblemTen(3));
            Console.WriteLine(ProblemTen(14));
            Console.WriteLine(ProblemTen(37));
        }

        //Basic Algoritm


        /*Write a C# Sharp program to compute the sum of the two given integer values. 
         If the two values are the same, then return triple their sum*/
        private static int ProblemOne(int num1, int num2)
        {
            return num1 == num2 ? (num1 + num2) * 3 : num1 + num2;
        }


        /*Write a C# Sharp program to get the absolute difference between n and 51. 
         If n is greater than 51 return triple the absolute difference.*/
        private static int ProblemTwo(int n)
        {
            return n > 51 ? (Math.Abs(n - 51)) * 3 : Math.Abs(n - 51);
        }

        /*Write a C# Sharp program to check two given integers, 
         and return true if one of them is 30 or if their sum is 30.*/
        private static bool ProblemThree(int num1, int num2)
        {
            return num1 == 30 || num2 == 30 || num1 + num2 == 30 ? true : false;
        }


        /*Write a C# Sharp program to check a given integer and 
         return true if it is within 10 of 100 or 200.*/

        private static bool ProblemFour(int num)
        {
            return num >= (100 - 10) && num <= 100 + 10 || num > (200 - 10) && num < 200 + 10 ? true : false;
        }


        /*Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
          If the string already begins with 'if', return the string unchanged.*/
        private static string ProblemFive(string input)
        {
            return input.Substring(0, 2).Equals("if") ? input : "if " + input;
        }


        /*Write a C# Sharp program to remove the character in a given position of a given string. 
          The given position will be in the range 0.. string length -1 inclusive.*/

        private static string ProblemSix(string input,int remove)
        {
            if(remove >= 0 && remove <= input.Length)
            {
                return input.Remove(remove, 1);
            }
            else
            {
                throw new Exception("Invalid Value");
            }
        }


        /*Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.*/

        private static string ProblemSeven(string input)
        {
            return input.Length > 1 ? input.Substring((input.Length - 1), 1) + input.Substring(1, (input.Length - 2)) + input.Substring(0, 1) : input;
        }

        /*Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. 
         If the given string length is less than 2 return the original string.*/

        private static string ProblemEight(string input)
        {
            return input.Length >= 2 ? input.Substring(0,2) + input.Substring(0, 2) + input.Substring(0, 2) + input.Substring(0, 2) : input;
        }


        /*Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.*/

        private static string ProblemNine(string input)
        {
            var lastchar =  input.Substring((input.Length-1), 1);
            return input.Length >= 1 ? lastchar + input + lastchar : input;
        }

        /*Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7*/

        private static bool ProblemTen(int num)
        {
            return num % 3 == 0 || num % 7 == 0 ? true : false; 
        }
    }
}
