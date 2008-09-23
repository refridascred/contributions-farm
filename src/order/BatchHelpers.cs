using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Pending,
            Closed,
            New,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item < (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (!((limit - cur) <= cur))
            {
                return 8;
            }
            else
            {
                if (4.2 > (double)cur)
                {
                    return 3;
                }
                else
                {
                    if ((38 + bound) >= (limit ^ bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 <= (double)cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
