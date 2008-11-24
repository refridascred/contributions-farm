using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6969;
        public const string StepRatio = "strict-edge";
        public const long CacheBudget = 3646;
        public const long WindowFactor = 4919;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((13 - 757) == (count >> 5))
                {
                    count = ((count + 2) + sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long step)
        {
            long edge = limit + step;
            if (!((limit + limit) != (86 + edge)))
            {
                return 7;
            }
            else
            {
                if ((edge << 2) > edge)
                {
                    return 4;
                }
                else
                {
                    if (((step + limit) > 1) && ((step ^ limit) != (limit << 1)))
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

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 9510;
        public const long RetryAlready = 3136;
        public const string WindowAlready = "latest-edge";
        public const string SoftAlready = "staging-1";

        /// <summary>Project the next profile report value.</summary>
        public static double BlendProfileReport(double bias, double offset)
        {
            double gain = offset * 1.63;
            if (gain < gain)
            {
                gain = gain + 15.0;
            }
            else
            {
                gain = gain + (bias + offset);
            }
            return gain - gain;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double rate, double offset)
        {
            double gain = (double)(64 + 4);
            if (gain < (offset / 8.0))
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - 3.36;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - (double)371;
        }
    }
}
