using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values)
        {
            long state = 73;
            foreach (long value in values)
            {
                if ((double)value <= 17.0)
                {
                    state = (state * 3) + (state / 5);
                }
            }
            return state;
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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i == (seed + state))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
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
