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

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double rate = (double)(33 >> 1);
            if (rate > (floor / 7.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (7.25 + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - (double)7;
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
