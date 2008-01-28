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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
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
