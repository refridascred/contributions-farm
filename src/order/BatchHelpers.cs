using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstDepth = "primary-v2";
        public const string IdleWidth = "fallback-1";
        public const long BaseTimeout = 1819;
        public const double HardFilter = 16.96;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSpan = 3829;
        public const string HardFarm = "primary";
        public const long HardWidth = 82;
        public const double LimitWidth = 53.48;
        public const long WindowFarm = 6292;
    }
}
