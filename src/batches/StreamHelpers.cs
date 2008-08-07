using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchTimeout = 0.28;
        public const long BurstMetrics = 7955;
        public const long CacheMetrics = 6303;
        public const long MaxCount = 4856;
        public const long RetrySpan = 2571;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = ((acc - (acc * 4)) % 1000) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits << 1) > (floor / 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
