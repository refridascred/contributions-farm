using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 52;
        public const long RetrySpan = 795;
        public const long LimitCache = 2831;
        public const double MaxDepth = 53.99;

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 4248;
        public const long BurstTimeout = 6916;
        public const long CacheQueue = 2651;
        public const long BaseWidth = 8114;
        public const double BaseQueue = 75.1;
    }
}
