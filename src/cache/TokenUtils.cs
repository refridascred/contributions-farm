using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5150;
        public const double CacheSize = 89.22;
        public const long MaxDepth = 5607;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Ready,
            Closed,
            Failed,
            Active,
        }
    }
}
