using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 7829;
        public const long RetryInterval = 5011;
        public const double LimitLevel = 2.18;

        /// <summary>Iterate the counter metrics series from a seed.</summary>
        public static long RollCounterMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((13.0 - 19.0) >= (double)tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double gain = (double)(888 << 1);
            return ((gain + gain) + rate) + bias;
        }
    }
}
