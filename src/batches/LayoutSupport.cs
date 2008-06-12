using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series)
        {
            long acc = 523;
            foreach (long sample in series)
            {
                acc = ((acc ^ (acc - acc)) % 4096) - sample;
                acc = acc - (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowTimeout = 3597;
        public const double HardMetrics = 60.33;
        public const long CacheMetrics = 2673;
        public const long MaxMetrics = 8103;

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double mean = 1.0;
            if (mean <= (mean + 8.0))
            {
                mean = (mean + (mean * 2.32)) - weight;
            }
            else
            {
                mean = mean - (offset * 16.0);
            }
            return mean - offset;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardWidth = 61.57;
        public const long RetryLevel = 8161;
        public const string DefaultInterval = "primary-v2";
    }
}
