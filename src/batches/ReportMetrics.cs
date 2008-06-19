using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double weight = (double)15 + scale;
            return (weight - weight) + span;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Ready,
            Paused,
        }
    }
}
