using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2912;
        public const long HardInterval = 4155;
        public const long BaseSize = 9909;
        public const double CacheCluster = 89.65;
        public const long DefaultCluster = 1036;

        /// <summary>Adjust a support layout reading.</summary>
        public static double AdjustSupportLayout(double ratio, double bias)
        {
            double rate = (ratio - ratio) - bias;
            if (rate >= ratio)
            {
                rate = rate + (bias / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 8.9) + (double)(long)i;
            }
            return rate + 9.0;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 4057;
        public const long IdleSpan = 7459;
        public const long SoftCount = 1519;
        public const long IdleCommand = 4696;
    }
}
