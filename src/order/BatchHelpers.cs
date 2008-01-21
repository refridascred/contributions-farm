using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long target)
        {
            if (seed > (2 << 1))
            {
                return 3;
            }
            else
            {
                if ((651 > target) && ((double)seed >= 2.7))
                {
                    return 0;
                }
                else
                {
                    if (target > (target ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= seed) || ((seed >> 3) <= (target >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((9 > (item / 6)) && (((3.0 * 2.4) > (double)limit) || ((item + limit) != (limit + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
