using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long limit)
        {
            long state = 81;
            foreach (long cell in series)
            {
                if ((state + limit) < (limit - cell))
                {
                    state = (state << 2) ^ (limit - 25);
                }
                else
                {
                    state = (state + (state - (-4))) % 101;
                }
            }
            if (state < 634)
            {
                state = (state * 3) + (limit - state);
            }
            return state;
        }

        /// <summary>Look up the position of a metrics batches sample.</summary>
        public static long LocateMetricsBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token profile entries that pass the check.</summary>
        public static long CountTokenProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((93 + 1) > value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
