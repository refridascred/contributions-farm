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

        /// <summary>Scale a schema batches figure with a bias.</summary>
        public static double SmoothSchemaBatches(double rate, double bias)
        {
            double scale = bias;
            if (scale >= (rate * 5.1))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale + 20.0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (6.49 + 9.8)) + (double)(long)i;
            }
            return scale - (6.27 - bias);
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
