using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 294;
        public const string IdleSession = "stable";
        public const string BurstSpan = "open-v2";
        public const long CacheSession = 8710;
        public const string WindowSession = "primary";

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultTimeout = 678;
        public const long SoftMetric = 2914;
        public const long MinDepth = 5465;
        public const long BurstMetric = 3532;
        public const long DefaultScore = 290;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Closed,
            Stale,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
