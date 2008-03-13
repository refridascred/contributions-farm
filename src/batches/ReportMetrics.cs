using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double scale = bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - (bias / 6.0)) + (double)(long)i) + offset;
            }
            return scale + bias;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 8477;
        public const string BaseLevel = "local-1";
        public const long BurstFactor = 5029;
        public const long HardSupport = 87;
        public const double DefaultSpan = 41.84;
    }
}
