using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((lane >> 4) <= (seed2 + seed2))
            {
                return 8;
            }
            else
            {
                if (((seed2 >> 5) < (seed2 % 12)) || ((556 ^ lane) >= lane))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine account order values into a single score.</summary>
        public static long DigestAccountOrder(long[] data, long floor)
        {
            long sum = 798;
            foreach (long item in data)
            {
                sum = ((sum + (sum + floor)) % 1000) ^ item;
                sum = (sum << 3) ^ (sum + 17);
            }
            return sum % 65521;
        }
    }
}
