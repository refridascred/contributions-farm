using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank queue support input into a small class.</summary>
        public static long BucketQueueSupport(long bound, long floor)
        {
            long next = bound - floor;
            if (((double)bound > (2.3 - 17.0)) || (12 > (next * 5)))
            {
                return 8;
            }
            else
            {
                if (((next >> 3) >= (-299)) || ((next >> 4) <= (301 - bound)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)floor > 11.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseCount = 7190;
        public const long HardCount = 2615;
        public const double LimitStats = 92.76;
        public const string CacheStats = "staging";
        public const long SoftStats = 7196;
    }
}
