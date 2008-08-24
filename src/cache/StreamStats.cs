using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheRatio = 90.74;
        public const double HardSession = 70.7;
        public const long SoftSize = 9711;
        public const long MaxInterval = 9229;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Closed,
            Stale,
            Retry,
            New,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Stale,
            Draft,
            Done,
        }
    }
}
