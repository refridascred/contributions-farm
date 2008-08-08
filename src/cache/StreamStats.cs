using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxRatio = "primary-v2";
        public const string MaxMetric = "stable-1";
        public const long DefaultTimeout = 1561;
        public const long LimitSpan = 5457;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 4949;
        public const long HardContributi = 6766;
        public const long DefaultContributi = 506;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Closed,
            Done,
            Stale,
        }
    }
}
