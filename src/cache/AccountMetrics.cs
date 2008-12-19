using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Weight { get; set; }
            public long Total { get; set; }
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

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long offset)
        {
            long bound = limit + offset;
            if (offset < (offset / 2))
            {
                return 4;
            }
            else
            {
                if (((offset / 8) >= (limit / 2)) && ((3 >> 2) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit <= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + limit) != (bound % 12))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long TallyEntrySupportMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((offset + seen) < 47)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
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
