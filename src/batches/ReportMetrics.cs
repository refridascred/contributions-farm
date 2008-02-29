using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double floor)
        {
            double load = floor;
            return (load + (load * 9.0)) + rate;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
