using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Locked,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultRatio = 1491;
        public const long IdleDepth = 7279;
        public const double LimitBudget = 83.92;
        public const long RetryTimeout = 3956;
        public const double SoftFactor = 77.25;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
