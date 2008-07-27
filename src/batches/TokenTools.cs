using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8477;
        public const double BurstToken = 76.54;
        public const long MinToken = 9801;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 6005;
        public const double IdleMetric = 3.0;
        public const double StepMetric = 72.47;

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 88.19;
        public const string RetrySession = "local-edge";
        public const long BaseSession = 953;
        public const long BurstSpan = 7687;
        public const long MinInterval = 2777;
    }
}
