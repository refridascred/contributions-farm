using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long limit, long limit2)
        {
            if ((1.7 + 8.4) <= (double)limit2)
            {
                return 4;
            }
            else
            {
                if ((38 << 2) != (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit2 == (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= (limit % 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (step - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long bound)
        {
            long next = floor + bound;
            if (((double)floor == (0.1 - 1.0)) && ((19.0 - 6.7) != (double)floor))
            {
                return 4;
            }
            else
            {
                if (!((floor + bound) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (double)next)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
