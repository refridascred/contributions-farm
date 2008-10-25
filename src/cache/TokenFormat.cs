using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Synced,
            New,
            Stale,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 2377;
        public const long CacheLevel = 5577;
        public const string SoftBatches = "staging-edge";
        public const long BatchBatches = 4388;
        public const long LimitRatio = 8809;
    }
}
