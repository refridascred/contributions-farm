using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepScore = 5562;
        public const long IdleCount = 1276;
        public const double CacheSpan = 9.95;
        public const string BurstLevel = "legacy-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 2537;
        public const long SoftDepth = 1882;
        public const string StepChannel = "staging-1";
        public const string CacheScore = "latest-1";
        public const string BaseTimeout = "strict";

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleSize = 52.36;
        public const long StepCount = 3537;
        public const double BatchOrder = 37.97;
    }
}
