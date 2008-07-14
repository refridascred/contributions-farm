using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1076;
        public const long MinContext = 2557;
        public const long CacheContext = 8694;
        public const long BurstInterval = 8592;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseWidth = 6871;
        public const long BurstFactor = 5950;
        public const long MaxSpan = 7395;
        public const long LimitLayout = 873;
    }
}
