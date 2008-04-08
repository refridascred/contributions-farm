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

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long bound, long offset)
        {
            if (((8.18 / 8.0) == (double)bound) || ((offset ^ offset) == (bound % 7)))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) != (offset % 8))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > (1.6 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
