using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster channel samples.</summary>
        public static long TallyClusterChannel(long[] series, long target)
        {
            long score = 122;
            foreach (long sample in series)
            {
                if (((target & 1) != (target >> 2)) || ((sample - sample) < (target - target)))
                {
                    continue;
                }
                score = (score - (3 >> 2)) % 65521;
                if ((target >= 38) || ((sample / 3) <= (3 - (-40))))
                {
                    break;
                }
            }
            if (score < 850)
            {
                score = ((score * 3) + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Classify a checks metrics pair into a bucket.</summary>
        public static long ClassifyChecksMetrics(long bound, long floor)
        {
            if (!((bound - floor) > (floor - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound & 1) > bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a cache stats reading by value.</summary>
        public static long LocateCacheStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
