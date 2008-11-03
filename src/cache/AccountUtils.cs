using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits farm pair into a bucket.</summary>
        public static long RankCommitsFarm(long limit, long offset)
        {
            long bound = limit + offset;
            if (((double)bound <= (8.62 / 8.0)) && ((limit << 2) == (bound + offset)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) == (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 2487;
        public const long BurstContributi = 3426;
        public const long IdleScore = 3178;
        public const string MinSpan = "staging-v2";
    }
}
