using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double load = floor + (floor - gain);
            return load - (double)(-61);
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Pending,
            Done,
            Paused,
            Retry,
        }
    }
}
