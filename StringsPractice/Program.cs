using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Vivian";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);

            //Escape Characters 

            //string myFaveQuote = "\"It's a yam sham\" - Buffy Summers";
            //Console.WriteLine(myFaveQuote); 


            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine \nHi";
            //string escapeString2 = "I want to show a backlash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);


            ////Matching strings 

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput == userTwoInput)
            //{
            //    Console.WriteLine("User 2 is a copycat");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}

            ////Another way to do this (multiple ways/built in methods)

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput.Equals(userTwoInput)) // <-- .Equal 
            //{
            //    Console.WriteLine("User 2 is a copycat");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");

            // }

            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Alicia";


            //string fullSentence = startOfSentence + endOfSentence;
            //// Console.WriteLine(fullSentence);
            //// fullSentence = string.Concat(startOfSentence, endOfSentence); <-- dont really use

            //Console.WriteLine(startOfSentence + endOfSentence);
            //// OR 
            //// Console.WriteLine(" My best friend's name is " + "Alicia");  
            //// Console.WriteLine(startOfSentence);
            //// Console.WriteLine(endOfSentence);     

            //Console.WriteLine("My friend " + endOfSentence + " has a cute puppy.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);

            // ONLY using ONE Console.WriteLine();
            // This is tab.
            // This is a backspace \.
            // This is a bell sound (\a)


            //Console.WriteLine("This is a tab. \t \nThis is a backspace \\. \nAnd this is a bell sound\a");

            // Group Porject

            string firstName = "Vivian";
            int lengthOfName = firstName.Length;
            Console.WriteLine(firstName);
            Console.WriteLine(lengthOfName);

            //Console.WriteLine(firstName + " is " + lengthOfName + " longer " );

            string lastName = "Pham";
            int lengthOfLast = lastName.Length;
            Console.WriteLine(lastName);
            Console.WriteLine(lengthOfLast);

            //Console.WriteLine(lastName + " is " + lengthOfLast + " shorter ");

            if (lengthOfName > lengthOfLast)
            {
                Console.WriteLine("First is longer!");
            }
            else if (lengthOfName == lengthOfLast)
            {
                Console.WriteLine("Samsis!");
            }
            else if (lengthOfName < lengthOfLast)
            {
                Console.WriteLine("Last must be longer!");
            }



        }

        

    }
}
