using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseCount = 3527;
        public const long BaseDepth = 5381;
        public const string WindowRecord = "legacy-v2";
        public const long BatchLevel = 5783;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowBudget = 4337;
        public const long BatchRatio = 5405;
        public const long HardInterval = 2318;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits - 9) < (hits - hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally ^ tally) > (tally + 699)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
