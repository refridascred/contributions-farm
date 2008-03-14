using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first account graph entry that matches the target.</summary>
        public static long SeekAccountGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long CountCommandBatchOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches == (5.3 * 3.39))
                {
                    matches = ((matches + 3) ^ cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchCount = 14.61;
        public const long RetryRatio = 4691;
        public const double MaxDepth = 83.31;
        public const string RetryLevel = "local-v2";
        public const long HardScore = 1084;

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long result = 19;
            foreach (long entry in levels)
            {
                if (((16.0 * 15.0) >= (double)entry) && (entry <= (entry + entry)))
                {
                    result = (result - (entry % 16)) % 255;
                }
            }
            if (result < 8)
            {
                result = (result << 2) ^ (result * 5);
            }
            return result % 97;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long score = 908;
            foreach (long cell in levels)
            {
                score = ((score - score) % 4096) + cell;
            }
            return score;
        }
    }
}
