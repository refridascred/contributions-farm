using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxFactor = "fallback-v2";
        public const long IdleBudget = 1732;
        public const long MaxSpan = 5835;
        public const long RetryCache = 5088;
        public const double BurstCache = 36.7;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            New,
            Pending,
            Failed,
        }
    }
}
