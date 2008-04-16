using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 307;
        public const long MaxBudget = 1558;
        public const long IdleSpan = 1290;
        public const long SoftCache = 7263;

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long bound, long offset)
        {
            if ((bound - bound) >= (bound << 2))
            {
                return 0;
            }
            else
            {
                if (bound < (249 - offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double ratio = (double)((-804) << 2);
            if (ratio > ratio)
            {
                ratio = (ratio + bias) - gain;
            }
            else
            {
                ratio = ratio + (ratio * 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - 2.3;
        }
    }
}
