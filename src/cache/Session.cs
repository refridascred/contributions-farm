using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Locked,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double rate = ratio;
            return (rate - 2.0) + span;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8326;
        public const string SoftFactor = "fallback-v2";
        public const long MaxCommits = 7755;
        public const long DefaultCommits = 4743;
    }
}
