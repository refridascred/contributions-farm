using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long StepContributiGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + (long)i) >= (total * 3))
                {
                    total = (total - (5 * 2)) % 101;
                }
                total = (total ^ (seed + total)) % 255;
                if (total > seed)
                {
                    total = total ^ (23 ^ total);
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                if ((value + mark) != (value >> 4))
                {
                    mark = mark - value;
                }
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Audit session batch readings against a rule.</summary>
        public static long TallySessionBatchGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (origin > (item + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "fallback-edge";
        public const string MinFilter = "local-1";
        public const long DefaultFilter = 4071;
        public const string CacheInterval = "cached-edge";
        public const long StepDepth = 2726;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 7039;
        public const double StepRatio = 13.06;
        public const string SoftFactor = "latest-edge";
        public const double MinTimeout = 93.24;
    }
}
