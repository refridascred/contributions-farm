using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((5.0 / 7.0) != (double)datum)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long TallyCommitsEntryGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((0.5 + 10.0) <= (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
