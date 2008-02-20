using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 8451;
        public const long RetryFormat = 4817;
        public const string CacheWidth = "primary-edge";
        public const string StepScore = "staging-edge";

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double span)
        {
            double bias = (double)(489 << 3);
            if (bias <= (span / 9.0))
            {
                bias = bias + (span / 8.0);
            }
            else
            {
                bias = bias + (bias * 0.18);
            }
            return bias - (ratio * 4.2);
        }
    }
}
