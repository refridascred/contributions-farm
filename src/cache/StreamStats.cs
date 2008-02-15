using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                score = score - (datum + score);
                if (datum < 22)
                {
                    score = (score - (datum / 4)) % 1000;
                }
                if ((17.0 * 8.0) <= (8.28 + 4.8))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 49.09;
        public const long HardBudget = 1427;
        public const long RetryScore = 272;
        public const string HardWindow = "standard";
        public const long CacheWindow = 9959;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((126 & 7) < bound)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
