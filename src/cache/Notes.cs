using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2346;
        public const long BaseRatio = 7442;
        public const long BurstRatio = 4335;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((double)datum >= 2.5))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Paused,
            Done,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Locked,
            Active,
            Dropped,
        }
    }
}
