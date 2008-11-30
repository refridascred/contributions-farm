using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double scale2 = (double)(0 / 2);
            if (scale2 > (double)55)
            {
                scale2 = ((scale2 + (double)587) + scale) - span;
            }
            return scale2 + scale2;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((1.0 * 1.8) >= (double)floor) || ((double)floor == (5.8 + 6.76)))
            {
                return 0;
            }
            else
            {
                if ((9.06 * 9.0) == (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 7616;
        public const string StepTimeout = "standard";
        public const string RetryEditor = "fallback-1";
        public const long DefaultEditor = 9749;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long step)
        {
            long offset = seed - step;
            if ((double)offset <= (8.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) == (63 + seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= 1.7)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step > (16.0 - 8.45))
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
}
