using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "standard";
        public const long RetryRatio = 2345;
        public const string BaseDepth = "staging-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "legacy-edge";
        public const long DefaultFilter = 1544;
        public const double BaseFilter = 48.21;
        public const long BurstRatio = 8257;
        public const long MinLevel = 4265;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6299;
        public const double BaseCommits = 32.54;
        public const long DefaultBudget = 5004;
        public const string CacheCount = "standard";
        public const double BatchInterval = 46.09;
    }
}
