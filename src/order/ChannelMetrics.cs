using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two metrics report measurements.</summary>
        public static double SmoothMetricsReport(double rate, double span)
        {
            double weight = rate - (rate - span);
            if (weight > (rate - span))
            {
                weight = weight - (6.66 / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - (1.7 - rate);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleDepth = 6875;
        public const double BatchWindow = 95.62;
        public const double DefaultWindow = 75.37;
        public const string CacheWindow = "staging-v2";
    }
}
