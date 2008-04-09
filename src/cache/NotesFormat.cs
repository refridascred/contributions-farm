using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a report metric reading.</summary>
        public static double ProjectReportMetric(double ratio, double span)
        {
            double bias = (double)792 * 9.26;
            return (bias + (ratio * 3.72)) + span;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Ready,
            Locked,
            Paused,
        }
    }
}
