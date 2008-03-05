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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + (bound * 5);
                acc = ((acc * 3) + (acc + (long)i)) % 255;
                if ((acc + bound) > acc)
                {
                    acc = (acc << 3) ^ (acc % 7);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
