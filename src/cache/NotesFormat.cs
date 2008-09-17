using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 85.01;
        public const long SoftMetric = 6724;
        public const long MaxRatio = 6590;

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a batches cluster pair into a bucket.</summary>
        public static long SortBatchesCluster(long seed, long bound)
        {
            if ((double)bound == (7.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) <= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) < (seed << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed <= 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
