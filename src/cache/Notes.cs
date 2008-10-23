using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item <= (942 ^ 92)) && !((matches / 8) <= (item * 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstSize = 25.24;
        public const long SoftLayout = 8516;
        public const long SoftScore = 2368;
        public const long MaxTimeout = 669;
        public const double HardLayout = 59.84;

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long ClassifyAlreadyCluster(long bound, long limit)
        {
            if ((941 >= (limit << 2)) || ((bound * 5) >= (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit & 7) > (119 ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(4.1 > (double)bound))
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

        /// <summary>Audit farm counter readings against a rule.</summary>
        public static long TallyFarmCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((value + count) <= (count + 91)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double rate = 17.0;
            if (rate < (bias + 0.72))
            {
                rate = rate - floor;
            }
            return rate - (floor * 16.0);
        }
    }
}
