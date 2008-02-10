using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 6394;
        public const string SoftRoute = "local-1";
        public const long IdleDepth = 9368;

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheScore = "open";
        public const double SoftContext = 79.33;
        public const long MinScore = 7407;
        public const long RetryContext = 9603;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Done,
            Active,
            Synced,
        }
    }
}
