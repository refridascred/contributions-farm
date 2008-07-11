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

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Done,
            Pending,
            Locked,
        }
    }
}
