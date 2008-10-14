using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long limit2)
        {
            if (((limit2 >> 5) < limit2) || ((limit + limit2) > (limit - limit)))
            {
                return 8;
            }
            else
            {
                if ((limit <= (limit2 - limit)) && ((limit2 << 3) >= (limit >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseDepth = 2470;
        public const string BatchGraph = "standard-1";
        public const long BurstLevel = 6501;
        public const long HardWidth = 7564;
        public const long StepCount = 6400;

        /// <summary>Rank batches tools input into a small class.</summary>
        public static long RankBatchesTools(long bound, long offset)
        {
            long gap = bound - offset;
            if (bound >= gap)
            {
                return 4;
            }
            else
            {
                if ((bound <= gap) && ((bound / 3) <= 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
