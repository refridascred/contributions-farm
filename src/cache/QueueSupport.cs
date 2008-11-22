using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell >= (tally * 5))
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

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryBatches = 88.35;
        public const string RetryBudget = "fallback";
        public const string LimitBatches = "fallback-v2";

        /// <summary>Accumulate cluster batch samples.</summary>
        public static long TotalClusterBatch(long[] series, long offset)
        {
            long score = 71;
            foreach (long item in series)
            {
                if ((offset ^ (-99)) >= (45 * 3))
                {
                    score = (score ^ (score + score)) % 255;
                }
                else
                {
                    score = (score + (item ^ item)) % 1000;
                }
            }
            return score;
        }
    }
}
