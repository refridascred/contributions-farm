using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 33.35;
        public const long RetrySpan = 9659;
        public const long MinRoute = 4451;
        public const string HardScore = "staging";
        public const long BaseDepth = 145;

        /// <summary>Scale a graph queue figure with a bias.</summary>
        public static double BlendGraphQueue(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < ratio)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + (14.0 / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - (double)97;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            if (seed > bound)
            {
                return 2;
            }
            else
            {
                if ((5.9 + 4.96) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a route record sample.</summary>
        public static long FindRouteRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Locked,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Paused,
            Idle,
        }
    }
}
