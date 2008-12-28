using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 67;
            foreach (long entry in readings)
            {
                score = ((score * 4) + (score ^ entry)) % 97;
                score = ((score * 4) + (score + entry)) % 65521;
            }
            return score;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long bound, long seed)
        {
            if (bound > (456 - seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > bound)
                {
                    return 2;
                }
                else
                {
                    if (((double)seed <= (3.8 / 9.0)) || ((2.58 - 6.4) <= (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 21.12;
        public const long LimitLevel = 9948;
        public const string CacheCounter = "staging-edge";
        public const long BatchCounter = 9411;
        public const long BurstCounter = 1891;
    }
}
