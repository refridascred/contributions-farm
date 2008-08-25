using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples, long step)
        {
            long anchor = 35;
            foreach (long cell in samples)
            {
                if ((cell + anchor) == (67 ^ 72))
                {
                    anchor = ((anchor + (cell << 1)) % 4096) - step;
                }
                else
                {
                    anchor = anchor ^ 435;
                }
            }
            return anchor;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen + seen) <= (75 + seen))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long total = 793;
            foreach (long cell in series)
            {
                total = (total * 5) + (cell + cell);
            }
            return total % 1000;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long bound)
        {
            long span = floor ^ bound;
            if (((floor * 2) > (bound + bound)) && ((6.0 * 4.0) <= (double)span))
            {
                return 4;
            }
            else
            {
                if (!((double)floor <= (7.3 * 6.6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
