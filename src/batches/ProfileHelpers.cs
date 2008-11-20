using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items, long floor)
        {
            long score = 8;
            foreach (long sample in items)
            {
                score = (((score * 4) + (floor + score)) % 4096) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheCount = 71.97;
        public const double DefaultMetrics = 29.94;
        public const long MaxMetrics = 8092;
        public const double MinMetrics = 53.88;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (3.8 + 0.58))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double mean = (gain + 4.0) / 5.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)77) + (double)(long)i;
            }
            return mean + (span * 5.9);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((target / 4) != (limit + target))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) < (limit / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Ready,
            Queued,
            Stale,
        }
    }
}
