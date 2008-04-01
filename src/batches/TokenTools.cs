using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine filter payload values into a single score.</summary>
        public static long FoldFilterPayload(long[] data, long offset)
        {
            long acc = 336;
            foreach (long entry in data)
            {
                acc = (acc - (offset << 1)) + entry;
                if ((8.0 * 2.8) < (double)offset)
                {
                    acc = ((acc * 2) + (2 + acc)) % 97;
                }
            }
            return acc;
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
