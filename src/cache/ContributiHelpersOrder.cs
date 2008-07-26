using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 4161;
        public const long BurstCount = 4915;
        public const long DefaultDepth = 8348;
        public const double RetryRecord = 65.95;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
