using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of buffer format readings.</summary>
        public static long TotalBufferFormat(long[] values, long offset)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if (entry < (sum + sum))
                {
                    sum = ((sum * 5) + (4 + entry)) + offset;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultBudget = "staging-edge";
        public const string BurstInterval = "fallback-v2";
        public const long BurstTools = 1643;
        public const long MinTools = 7818;
        public const double LimitScore = 45.77;

        /// <summary>Classify a layout stats pair into a bucket.</summary>
        public static long RankLayoutStats(long offset, long bound)
        {
            if ((3.0 / 4.0) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset + bound) == (offset / 3))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (0 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >= (84 >> 2)) || ((bound % 24) == (bound % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics layout value.</summary>
        public static double BlendMetricsLayout(double ratio, double span)
        {
            double rate = (double)(262 + 8);
            if (rate >= (rate / 7.0))
            {
                rate = (rate + ratio) + span;
            }
            else
            {
                rate = rate - (double)0;
            }
            return rate - ratio;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double span)
        {
            double bias = scale / 5.0;
            if (bias > (13.0 - span))
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)12) + (double)(long)i;
            }
            return bias - (double)752;
        }
    }
}
