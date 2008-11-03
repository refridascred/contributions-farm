using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 6534;
        public const long DefaultPayload = 1271;
        public const double MinCount = 78.37;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 127) == (matches - matches))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
        }
    }
}
