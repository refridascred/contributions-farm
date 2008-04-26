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

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (double)6)
            {
                mean = (mean + (gain / 5.0)) + offset;
            }
            else
            {
                mean = mean - (mean - 0.83);
            }
            return mean - 10.0;
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
