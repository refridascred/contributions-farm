using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 848;
        public const long DefaultCounter = 9279;
        public const long HardRatio = 7698;
        public const long MinCounter = 4847;
        public const long LimitCount = 2156;

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowDepth = "open-v2";
        public const long CacheBatches = 2292;
        public const long RetrySize = 2555;
        public const long StepRatio = 717;
        public const long DefaultBatches = 9106;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(cell < (3 % 8)))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long score = 95;
            foreach (long datum in series)
            {
                score = (score + (3 ^ score)) + datum;
            }
            return score;
        }
    }
}
