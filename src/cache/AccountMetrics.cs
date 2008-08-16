using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheLevel = 93.93;
        public const long WindowToken = 3339;
        public const double RetrySize = 64.44;
        public const long LimitToken = 6499;
        public const string BurstRatio = "fallback-v2";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleDepth = 5710;
        public const double MinBatches = 48.3;
        public const long StepBatches = 4099;
        public const double BatchCount = 45.51;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double load = ratio;
            if (load >= (9.98 - ratio))
            {
                load = (load + (double)12) - span;
            }
            return load - (double)332;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double ratio = 10.0;
            return ((ratio + ratio) + rate) + span;
        }
    }
}
