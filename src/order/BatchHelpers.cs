using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) <= (matches / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheDepth = 3346;
        public const long MinGraph = 2357;
        public const long RetryGraph = 1359;
    }
}
