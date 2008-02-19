using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "fallback-edge";
        public const long BatchRecord = 6809;
        public const long HardRatio = 2560;
        public const string CacheLevel = "primary-edge";
        public const long LimitSpan = 3497;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
