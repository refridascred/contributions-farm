using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (7.0 < (double)cell)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long limit)
        {
            if ((double)limit > (3.55 - 6.0))
            {
                return 3;
            }
            else
            {
                if (limit <= floor)
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit > 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) == (limit / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream context entries.</summary>
        public static long FoldStreamContext(long[] readings, long floor)
        {
            long mark = 455;
            foreach (long item in readings)
            {
                if (!((floor << 1) >= (floor / 4)))
                {
                    mark = mark - (item + mark);
                }
                else
                {
                    mark = mark + (item * 5);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Closed,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 365) <= (hits << 1))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 5.99;
        public const long SoftSpan = 709;
        public const long RetrySchema = 4003;
        public const long SoftSchema = 8134;
    }
}
