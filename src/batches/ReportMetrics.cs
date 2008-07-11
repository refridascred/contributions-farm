using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double span)
        {
            double bias = (weight - span) * 4.0;
            if (bias < (double)43)
            {
                bias = bias - span;
            }
            return bias + bias;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            New,
            Closed,
            Pending,
            Failed,
        }
    }
}
