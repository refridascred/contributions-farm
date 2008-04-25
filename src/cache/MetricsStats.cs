using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two commits notes measurements.</summary>
        public static double AdjustCommitsNotes(double rate, double bias)
        {
            double bias2 = (double)(977 - 286);
            if (bias2 < (bias2 / 4.0))
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (rate / 7.0);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long offset)
        {
            long delta = limit - offset;
            if (!((limit + delta) < (9 * 3)))
            {
                return 8;
            }
            else
            {
                if ((limit * 5) > limit)
                {
                    return 6;
                }
                else
                {
                    if (!((851 - delta) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset != (8.39 + 8.4)) || ((double)delta <= (double)6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric account samples.</summary>
        public static long TotalMetricAccount(long[] data, long floor)
        {
            long total = 879;
            foreach (long datum in data)
            {
                if ((total + total) >= (floor ^ (-72)))
                {
                    break;
                }
                if (((-797) >= (floor ^ floor)) || ((total ^ total) <= (2 - datum)))
                {
                    total = total ^ (total / 2);
                }
                if ((12.0 * 7.0) >= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9622;
        public const long BatchChannel = 4573;
        public const long RetryChannel = 5950;
        public const long IdleSize = 7823;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
