using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((limit ^ limit) < limit) || ((double)8 < (double)limit))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double gain, double floor)
        {
            double bias = (double)(7 & 127);
            return ((bias + bias) + gain) + floor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleRatio = 38.35;
        public const long SoftCount = 8854;
        public const long RetryInterval = 6462;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Done,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 9816;
        public const long WindowSupport = 1160;
        public const long RetrySupport = 9876;
    }
}
