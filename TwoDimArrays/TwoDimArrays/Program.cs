namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[5, 3]
                {
                { "İstanbul", "Edirne", "Tekirdağ"},
                { "İzmir", "Muğla", "Aydın"},
                { "Nevşehir", "Ankara", "Konya"},
                { "Rize", "Trabzon", "Samsun"},
                { "Antalya", "Mersin", "Adana"},
                };
            foreach (string region in regions)
            {
                Console.WriteLine(region);
            }
            Console.WriteLine();


            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***************************");
            }

            Console.ReadLine();

        }


    }
}