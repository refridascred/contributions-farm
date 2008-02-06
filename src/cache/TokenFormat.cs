using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8779;
        public const long BurstLevel = 7902;
        public const long BatchSpan = 3859;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryTimeout = 9290;
        public const string CacheRatio = "legacy";
        public const double LimitDepth = 72.96;
        public const long RetryCounter = 8383;
        public const string CacheSize = "standard-edge";
    }
}
