using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 6757;
        public const long HardSupport = 5927;
        public const double BaseInterval = 79.99;
        public const string WindowFactor = "latest-v2";

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Pending,
            Paused,
        }
    }
}
