using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double bias)
        {
            double rate = (weight - weight) - bias;
            if (rate <= (6.07 / 2.0))
            {
                rate = rate - bias;
            }
            return rate - bias;
        }
    }
}
