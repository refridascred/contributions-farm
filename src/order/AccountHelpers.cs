using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long TallyStatsBufferHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= 9.5) && ((double)tally < (double)cell))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long TallyGraphToolsHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (50 <= (seed << 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a account counter value against two limits.</summary>
        public static long BucketAccountCounter(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((delta + bound) >= bound)
            {
                return 4;
            }
            else
            {
                if (bound2 <= delta)
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound2) > (bound2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 >= (bound2 - 44)) && ((double)bound <= (6.01 * 7.1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7491;
        public const long StepMetrics = 9611;
        public const long HardSize = 8441;
        public const long MaxRatio = 4302;
        public const double CacheRatio = 31.06;

        /// <summary>Validate order metrics readings against a bound.</summary>
        public static bool GuardOrderMetricsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double bias, double floor)
        {
            double ratio = bias;
            return (ratio + (ratio / 2.0)) + floor;
        }
    }
}
