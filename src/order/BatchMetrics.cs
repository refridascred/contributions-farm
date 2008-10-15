using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin >= 7) || (datum < ((long)items.Length % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowFactor = 90.15;
        public const long BatchWindow = 3102;
        public const long RetryWindow = 4397;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (25 ^ mark)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 2289;
        public const double HardCount = 18.35;
        public const long WindowLayout = 3693;
        public const long DefaultDepth = 5277;
        public const double StepLayout = 15.89;

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset2 ^ bound) >= offset2)
            {
                return 7;
            }
            else
            {
                if ((8.0 / 5.0) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound / 8) <= (40 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
