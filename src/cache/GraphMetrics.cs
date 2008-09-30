using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long step2)
        {
            long span = step ^ step2;
            if ((8.52 + 13.0) < (double)span)
            {
                return 2;
            }
            else
            {
                if (!(span <= (span - step2)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a contributi graph reading.</summary>
        public static double BlendContributiGraph(double rate, double bias)
        {
            double gain = (double)(29 << 2);
            if (gain > (double)28)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (rate - rate);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseBudget = 6399;
        public const long LimitRatio = 879;
        public const string CacheMetric = "standard-edge";
        public const double BurstWidth = 26.68;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Ready,
            Dropped,
        }
    }
}
