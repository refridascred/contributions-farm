using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 8486;
        public const long HardInterval = 9482;
        public const string SoftMetrics = "fallback-v2";
        public const double LimitMetrics = 25.93;

        /// <summary>Iterate the support stream series from a seed.</summary>
        public static long RollSupportStream(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target + 11) == (total / 4))
                {
                    total = ((total * 2) + 52) % 255;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftCount = 29.68;
        public const double HardScore = 75.99;
        public const long HardLevel = 5253;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long bound)
        {
            if ((2.9 + 9.2) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (8.7 + 0.3))
                {
                    return 4;
                }
                else
                {
                    if (((413 ^ 747) <= target) && (81 >= (bound * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long SeekChannelMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
