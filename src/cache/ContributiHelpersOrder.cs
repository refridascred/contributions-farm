using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long CountBatchesChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 15) < (cell - cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) >= (83 + item))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
