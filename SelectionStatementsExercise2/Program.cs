namespace SelectionStatementsExercise2
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("What is your favorite School subject?");
            var subject = Console.ReadLine();
            
            switch (subject)
            { 
                case "Math":
                    Console.WriteLine("Math is too hard of a subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is a hard subject!");
                    break;
                case "History":
                    Console.WriteLine("History Class is very interesting subject!");
                    break;
                default:
                    Console.WriteLine($"Oh Wow! I never took this subject before. {subject} sounds fun!");
                    break;
                }
            }
            
        }
        
    }
    