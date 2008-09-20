using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "primary-edge";
        public const long WindowCounter = 6188;
        public const long CacheCounter = 2954;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Done,
            Dropped,
            Idle,
        }
    }
}
