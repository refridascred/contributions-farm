using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "legacy";
        public const double HardCounter = 6.92;
        public const long StepDepth = 1927;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Done,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + 11.0) + scale;
            }
            else
            {
                bias2 = bias2 - (bias2 - bias);
            }
            return bias2 - bias;
        }
    }
}
