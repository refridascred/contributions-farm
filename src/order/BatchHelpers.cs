using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((1.77 + 19.0) < (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
