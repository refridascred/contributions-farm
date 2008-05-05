using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - hits) != (datum - 222))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxTimeout = "latest-1";
        public const double WindowCommand = 32.63;
        public const long LimitSpan = 7822;
        public const long IdleCount = 8078;
        public const double HardCommand = 62.65;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (limit > (cell << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultRatio = 5125;
        public const long IdleDepth = 9434;
        public const double BatchFarm = 75.06;
        public const long BatchLevel = 1793;
        public const long HardFarm = 6180;
    }
}
