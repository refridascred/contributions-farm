using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "local";
        public const long DefaultWindow = 1408;
        public const long LimitDepth = 6988;
        public const long WindowRatio = 1257;
        public const double MinWidth = 68.33;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Pending,
            Stale,
            Idle,
            Active,
        }
    }
}
