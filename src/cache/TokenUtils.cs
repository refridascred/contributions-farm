using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 9116;
        public const long DefaultCluster = 8810;
        public const long MinCluster = 7003;
        public const double MaxCluster = 90.55;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardTimeout = 6619;
        public const double MinLevel = 76.85;
        public const long RetryCount = 8471;
        public const long BurstScore = 2470;
    }
}
