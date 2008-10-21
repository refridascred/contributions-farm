using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank record cluster input into a small class.</summary>
        public static long SortRecordCluster(long limit, long seed)
        {
            long gap = limit + seed;
            if ((limit * 5) > gap)
            {
                return 0;
            }
            else
            {
                if (((-1) << 2) < (gap * 5))
                {
                    return 6;
                }
                else
                {
                    if (((2.6 + 6.8) == (double)limit) || ((limit - gap) >= (61 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally << 2) > (tally + floor))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
