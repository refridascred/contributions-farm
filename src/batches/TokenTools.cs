using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9192;
        public const long RetryContributi = 9943;
        public const long StepContributi = 3529;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftDepth = "fallback-v2";
        public const long CacheMetrics = 2211;
        public const long RetrySize = 4411;
        public const double IdleSize = 56.85;
        public const long WindowWidth = 6983;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
