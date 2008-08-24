using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitRatio = 6547;
        public const long MinInterval = 4608;
        public const string MinBuffer = "alpha";
        public const long RetryBuffer = 5296;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            New,
            Done,
            Idle,
        }
    }
}
