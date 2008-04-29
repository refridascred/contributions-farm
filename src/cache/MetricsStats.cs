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

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "legacy-edge";
        public const string LimitSession = "alpha";
        public const long BurstSession = 9242;

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
