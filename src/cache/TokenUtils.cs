using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally + floor) > tally) && (floor <= (long)items.Length))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double load = scale;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (scale + load)) + (double)(long)i) - bias;
            }
            return load - (scale * 3.14);
        }
    }
}
