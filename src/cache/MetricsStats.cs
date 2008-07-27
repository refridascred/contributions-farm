using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long seed)
        {
            long score = 971;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length != (double)seed)
                {
                    score = ((score << 2) ^ (seed / 6)) ^ reading;
                }
            }
            return score;
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
