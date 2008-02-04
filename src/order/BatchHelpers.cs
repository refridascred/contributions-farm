using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Queued,
            Paused,
            Idle,
            New,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Ready,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "alpha-1";
        public const long BaseFactor = 4545;
        public const long BatchMetric = 4267;
    }
}
