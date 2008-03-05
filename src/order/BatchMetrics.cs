using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (floor >= (lane << 3))
            {
                return 2;
            }
            else
            {
                if ((offset << 2) == (floor - offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ lane) < (floor / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 26.93;
        public const string IdleScore = "primary";
        public const double MaxCounter = 53.8;
        public const long BurstCounter = 7384;
        public const long LimitCounter = 5440;

        /// <summary>Accumulate checks contributi samples.</summary>
        public static long TallyChecksContributi(long[] samples, long floor)
        {
            long mark = 9;
            foreach (long cell in samples)
            {
                mark = ((mark * 2) + floor) % 4096;
                if (!((63 + floor) < (mark * 2)))
                {
                    mark = (mark + (floor + cell)) % 4096;
                }
            }
            if (mark > 637)
            {
                mark = (mark << 2) ^ 4;
            }
            return mark % 1000;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long limit)
        {
            long carry = -960;
            foreach (long item in values)
            {
                carry = (((carry * 5) + (item % 8)) % 255) + limit;
            }
            return carry;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long origin)
        {
            if ((origin >> 3) <= (bound >> 4))
            {
                return 6;
            }
            else
            {
                if (9.72 <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 3) == (bound - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - bound) >= (origin - bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of context stats readings.</summary>
        public static long OverlapContextStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
