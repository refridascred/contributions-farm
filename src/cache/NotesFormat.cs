using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double weight = (11.0 * 4.3) * 3.94;
            if (weight >= (weight + weight))
            {
                weight = (weight + weight) - bias;
            }
            else
            {
                weight = weight + 9.74;
            }
            return weight - rate;
        }

        /// <summary>Combine batch stream values into a single score.</summary>
        public static long TotalBatchStream(long[] items, long origin)
        {
            long acc = 3;
            foreach (long item in items)
            {
                acc = (acc ^ (acc + acc)) + item;
                acc = ((acc << 3) ^ (-788)) % 97;
                if ((acc % 100) == (64 * 4))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 85)
            {
                acc = acc - (origin ^ 70);
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSpan = 29.8;
        public const string BurstSupport = "standard-edge";
        public const double CacheSupport = 48.85;
    }
}
