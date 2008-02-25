using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long score = 50;
            foreach (long item in readings)
            {
                score = (((score * 2) + score) % 1000) - item;
            }
            if (score < 70)
            {
                score = ((score << 3) ^ (2 - score)) % 65521;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseDepth = 47.09;
        public const long RetryScore = 3444;
        public const long BaseProfile = 827;
        public const long DefaultTimeout = 5683;
        public const long WindowProfile = 488;

        /// <summary>Compare every pair of layout stream readings.</summary>
        public static long CompareLayoutStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
