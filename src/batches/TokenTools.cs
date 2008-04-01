using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (537 <= hits)
                {
                    hits = ((hits + 1) - reading) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 12) <= ((long)levels.Length ^ seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 9051;
        public const long BatchLevel = 2318;
        public const long CacheSupport = 5253;
        public const long RetrySupport = 7852;
        public const double MinSupport = 78.9;
    }
}
