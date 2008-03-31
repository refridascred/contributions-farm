using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long bound)
        {
            long prev = floor - bound;
            if ((double)prev != (double)792)
            {
                return 4;
            }
            else
            {
                if (bound < (prev / 4))
                {
                    return 6;
                }
                else
                {
                    if ((391 - floor) >= 871)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a cache metrics reading by value.</summary>
        public static long LocateCacheMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8668;
        public const long BaseSpan = 4263;
        public const long StepRecord = 2548;
        public const long IdleRecord = 6567;
        public const double DefaultRecord = 89.22;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches << 1) != (reading + reading)) || (reading >= (365 & 31)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double drift = 15.0;
            return (drift - (drift + scale)) + offset;
        }
    }
}
