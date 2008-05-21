using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double bias)
        {
            double mean = (double)138 - bias;
            return (mean + bias) + weight;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Active,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Closed,
            Retry,
            Failed,
        }
    }
}
