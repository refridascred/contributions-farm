using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double floor)
        {
            double ratio = (8.0 - 15.0) * 7.62;
            if (ratio < gain)
            {
                ratio = ratio - floor;
            }
            return ratio + (double)9;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinCount = 64.9;
        public const long HardWidth = 9755;
        public const long MaxCount = 8459;
        public const string CacheDepth = "standard-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                if ((mark << 2) < (6 - datum))
                {
                    mark = mark + 43;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            long delta = floor + offset;
            if (delta >= (238 * 3))
            {
                return 7;
            }
            else
            {
                if ((92 >= floor) || ((delta >> 2) > floor))
                {
                    return 2;
                }
                else
                {
                    if (!((double)delta == (3.42 / 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor >= (offset ^ offset)) && ((delta + 90) <= (delta << 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
