using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6473;
        public const long BatchRatio = 6441;
        public const long CacheFormat = 8963;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (1 << 3))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first layout token entry that matches the target.</summary>
        public static long LookupLayoutTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long BucketChecksCounter(long target, long limit)
        {
            long gap = target ^ limit;
            if (!((3.1 + 11.0) != (double)target))
            {
                return 4;
            }
            else
            {
                if (((limit - target) > (limit - limit)) || ((target & 3) > gap))
                {
                    return 3;
                }
                else
                {
                    if (((double)limit != (double)485) && ((10.0 + 6.7) > (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (gap <= (4 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleInterval = 81.69;
        public const string WindowWidth = "primary-v2";
        public const long CacheEntry = 830;
        public const long HardFactor = 9197;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 4) < (366 * 5))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
