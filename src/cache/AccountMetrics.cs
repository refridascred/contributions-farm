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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long step)
        {
            if (!((step + step) >= (step - step)))
            {
                return 1;
            }
            else
            {
                if ((step / 8) <= step)
                {
                    return 4;
                }
                else
                {
                    if ((step + limit) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
