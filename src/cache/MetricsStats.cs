using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a batches format pair into a bucket.</summary>
        public static long ClassifyBatchesFormat(long seed, long floor)
        {
            long delta = seed ^ floor;
            if (((seed << 1) < (delta - seed)) && ((8.0 / 2.0) >= (double)seed))
            {
                return 8;
            }
            else
            {
                if ((double)94 == (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((596 ^ 8) <= delta)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (seed >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftTimeout = 3714;
        public const long IdleGraph = 9062;
        public const string IdleBudget = "stable-edge";
        public const long RetryBudget = 4727;
        public const long MaxGraph = 2258;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((3.8 * 8.4) <= (double)datum)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Match up layout metric samples.</summary>
        public static long OverlapLayoutMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long mark = 28;
            foreach (long datum in series)
            {
                mark = mark - datum;
                mark = ((mark << 3) ^ datum) % 255;
            }
            if (mark > 506)
            {
                mark = (mark - (mark / 8)) % 97;
            }
            return mark;
        }
    }
}
