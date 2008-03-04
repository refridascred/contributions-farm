using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 4455;
        public const string IdleWidth = "fallback-1";
        public const long BatchDepth = 1343;
        public const long HardLevel = 3446;
        public const double HardFilter = 14.0;
    }
}
