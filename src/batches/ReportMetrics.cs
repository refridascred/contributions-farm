using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "standard-v2";
        public const long CacheSpan = 3859;
        public const long WindowRatio = 3343;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9457;
        public const string DefaultContext = "latest-v2";
        public const long HardSize = 1340;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
