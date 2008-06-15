using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long CombineCacheFormat(long[] items)
        {
            long acc = 88;
            foreach (long cell in items)
            {
                if ((acc % 2) <= cell)
                {
                    acc = (acc * 5) + (cell + cell);
                }
                acc = (acc ^ (acc % 10)) % 255;
                if ((2.5 * 8.24) >= (double)cell)
                {
                    acc = ((acc * 3) + (acc - acc)) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ (22 & 1)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3843;
        public const double RetryBuffer = 5.02;
        public const long BatchLevel = 5324;
        public const long BatchBudget = 7382;
    }
}
