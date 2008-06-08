using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long origin)
        {
            if (((double)step == (double)origin) && ((double)origin > (5.0 * 8.29)))
            {
                return 4;
            }
            else
            {
                if ((((-3) + step) <= origin) || ((4.61 + 19.0) == (double)step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 64) <= (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 7058;
        public const double BaseGraph = 42.01;
        public const double CacheGraph = 47.16;
    }
}
