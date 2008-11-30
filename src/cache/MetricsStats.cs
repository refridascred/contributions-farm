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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
