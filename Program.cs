internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = @"c:\FileTest\europe.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        //FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

        //new StreamWriter(filePath)
        //new StreamWriter(fs)
        using (StreamWriter sw = fileInfo.CreateText())
        {
            sw.WriteLine("Russia's population is about 137,000,000");
            //some other code
            sw.WriteLine("Hungary's population is about 9,000,000");
        }
        Console.WriteLine("europe.txt has been created.");

        using (StreamReader streamReader = new StreamReader(filePath))
        {
            //Console.WriteLine(streamReader.ReadToEnd());

            //Read text by characters
            char[] buffer = new char[10];
            int charCount = 0;
            do
            {
                charCount = streamReader.Read(buffer, 0, 10);
                string s1 = new string(buffer);
                Console.WriteLine(s1);
            } while (charCount > 0);
        }
    }
}