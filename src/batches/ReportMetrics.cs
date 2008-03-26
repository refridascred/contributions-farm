using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 10.31;
        public const double RetryPayload = 17.95;
        public const long BatchInterval = 1894;

        /// <summary>Blend two token checks measurements.</summary>
        public static double BlendTokenChecks(double weight, double span)
        {
            double gain = (span - span) + span;
            if (gain <= span)
            {
                gain = (gain - (span / 8.0)) - weight;
            }
            else
            {
                gain = gain + span;
            }
            return gain + gain;
        }
    }
}
