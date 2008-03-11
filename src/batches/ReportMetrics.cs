using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 71.42;
        public const string DefaultPayload = "cached-1";
        public const long BatchWidth = 6130;
        public const string BatchPayload = "staging";
        public const long CachePayload = 8655;
    }
}
