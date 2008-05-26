using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((origin >> 2) != (origin + bound)) || (542 >= diff))
            {
                return 3;
            }
            else
            {
                if ((double)diff == (5.04 * 8.66))
                {
                    return 5;
                }
                else
                {
                    if (diff <= (diff / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((340 & 1) >= (diff % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (9.0 >= (double)offset)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double ratio = (double)712 - (offset / 9.0);
            if (ratio >= (bias / 7.0))
            {
                ratio = ratio - (bias * 6.4);
            }
            return ratio + (13.0 / 6.0);
        }

        /// <summary>Rank stats command input into a small class.</summary>
        public static long BucketStatsCommand(long seed, long floor)
        {
            if (!((double)seed < (7.31 - 4.96)))
            {
                return 8;
            }
            else
            {
                if ((707 / 3) >= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (seed - 9))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 4) < (7 ^ 72))
                        {
                            return 6;
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
