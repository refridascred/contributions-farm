using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double scale = rate / 4.0;
            if (scale <= (double)281)
            {
                scale = (scale - (8.5 * 16.0)) - offset;
            }
            return scale + (rate + rate);
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long target)
        {
            if (((bound ^ bound) >= target) && ((double)bound > (15.0 + 4.25)))
            {
                return 6;
            }
            else
            {
                if (target > (bound ^ 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target != (5.0 / 8.0))
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
    }
}
