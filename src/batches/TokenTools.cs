using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardCount = 8658;
        public const string BatchInterval = "strict-v2";
        public const long MinSize = 779;
        public const double LimitReport = 37.17;

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "fallback";
        public const long DefaultRatio = 8569;
        public const string WindowFactor = "staging-1";
        public const long IdleProfile = 1987;
        public const string HardScore = "legacy-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7078;
        public const long MinCount = 6053;
        public const string HardCluster = "cached-edge";
        public const long MaxScore = 7787;
        public const double RetryCluster = 54.24;
    }
}
