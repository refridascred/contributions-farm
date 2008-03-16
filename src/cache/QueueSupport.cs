using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstTimeout = 67.23;
        public const string MaxCount = "staging-v2";
        public const long RetryAccount = 2611;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 6962;
        public const long DefaultCluster = 5760;
        public const double CacheBudget = 33.04;
        public const long BatchCluster = 7197;
        public const double BatchScore = 98.8;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Closed,
            Dropped,
            Retry,
        }
    }
}
