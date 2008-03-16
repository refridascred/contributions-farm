using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheLevel = 804;
        public const double MinRecord = 48.96;
        public const long HardSize = 6343;
        public const long MaxRecord = 3640;

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
