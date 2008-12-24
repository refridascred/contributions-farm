using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((hits - cell) <= (cell - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a account report pair into a bucket.</summary>
        public static long SortAccountReport(long origin, long origin2)
        {
            if (origin2 > (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((origin2 + origin) != (origin2 / 6))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long target, long limit)
        {
            long cur = target ^ limit;
            if (96 < (target % 2))
            {
                return 0;
            }
            else
            {
                if (target >= (target + 34))
                {
                    return 8;
                }
                else
                {
                    if ((target - target) > (limit * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)cur < 18.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor + target;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
