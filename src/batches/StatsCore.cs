using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ limit) > limit)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long bound)
        {
            if (!((0.7 * 9.0) >= (double)bound))
            {
                return 8;
            }
            else
            {
                if (3 > (bound * 4))
                {
                    return 0;
                }
                else
                {
                    if (!(9 < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a githubfarm filter reading.</summary>
        public static double ScaleGithubfarmFilter(double rate, double bias)
        {
            double drift = (double)(9 % 16);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (bias - drift)) - (double)(long)i) - rate;
            }
            return drift - bias;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double ScaleMetricsContributi(double gain, double span)
        {
            double load = span + span;
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - (gain * 6.07);
        }
    }
}
