using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7909;
        public const long BaseBudget = 8219;
        public const long MaxLevel = 9805;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)tally <= (1.0 / 8.0)) && ((tally - cell) >= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next session route value.</summary>
        public static double BlendSessionRoute(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)(-3))
            {
                ratio = (ratio - (ratio + 6.5)) - bias;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            if (((9.8 - 4.1) != (double)step) && (origin < (1 / 8)))
            {
                return 5;
            }
            else
            {
                if ((6.0 / 8.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step <= origin) && ((step % 60) != (origin * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
