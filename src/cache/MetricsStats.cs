using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double scale = (floor + floor) * 0.95;
            if (scale < (floor * 5.0))
            {
                scale = (scale + scale) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 7.0)) + (double)(long)i;
            }
            return scale + (9.0 - floor);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long step)
        {
            if ((5.94 / 4.0) <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((664 << 2) == (step + floor))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheRatio = 4315;
        public const long BaseDepth = 5709;
        public const double MinCount = 41.34;
    }
}
