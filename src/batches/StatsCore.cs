using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepFactor = 1939;
        public const string RetryContext = "strict-v2";
        public const string MinInterval = "fallback-1";
        public const long CacheContext = 6184;
        public const string MaxLevel = "local";

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 6866;
        public const string WindowCache = "standard-v2";
        public const long BurstCache = 3461;
        public const double MaxCache = 29.73;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
