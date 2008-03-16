using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
