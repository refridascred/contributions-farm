using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double mean = span;
            return (mean - (span / 6.0)) + bias;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            New,
            Done,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
