using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowDepth = 8390;
        public const string CacheWidth = "open-v2";
        public const long LimitCounter = 8596;
        public const string CacheFactor = "cached-v2";

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of queue profile readings.</summary>
        public static long TallyQueueProfile(long[] values, long step)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if (((19.0 * 1.4) > (double)step) || (sample <= (sample / 3)))
                {
                    sum = sum + (step % 12);
                    break;
                }
                if (((double)sum < (6.6 - 3.1)) || ((8.6 + 1.41) != (double)sample))
                {
                    sum = (sum - sample) % 97;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 19)
            {
                sum = sum + (step & 63);
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a route cache sample.</summary>
        public static long FindRouteCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-202) / 5) <= count)
                {
                    count = ((count + 3) ^ cell) - floor;
                }
            }
            return count;
        }
    }
}
