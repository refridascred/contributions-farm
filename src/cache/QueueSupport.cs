using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if ((floor << 1) >= (limit * 4))
            {
                return 7;
            }
            else
            {
                if ((limit > floor) || ((double)floor <= (7.5 * 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long floor)
        {
            if ((3.0 - 3.69) >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((floor ^ floor) < target)
                {
                    return 5;
                }
                else
                {
                    if ((8.99 * 20.0) == (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + target) == (floor * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) < (value - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
