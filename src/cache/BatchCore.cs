using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8577;
        public const long MinMetric = 7162;
        public const string CacheSpan = "fallback-1";
        public const long WindowMetric = 1056;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 7866;
        public const long MaxCount = 6120;
        public const long WindowSize = 815;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Pending,
            Ready,
            Queued,
            Failed,
        }
    }
}
