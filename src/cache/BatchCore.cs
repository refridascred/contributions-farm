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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((double)item >= (5.7 / 8.0)) || ((item << 2) < (989 % 12))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
