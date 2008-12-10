using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long limit)
        {
            if (!((9.41 / 9.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((limit > floor) && ((7.19 / 6.0) != (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) > (floor * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((3 - 77) != (count + 770))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Closed,
            Active,
            Synced,
            Ready,
        }
    }
}
