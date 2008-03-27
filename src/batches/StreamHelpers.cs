using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine token route values into a single score.</summary>
        public static long WeighTokenRoute(long[] readings, long limit)
        {
            long state = 47;
            foreach (long item in readings)
            {
                if (item > 8)
                {
                    state = ((state ^ (item % 10)) % 1000) - limit;
                }
            }
            return state % 97;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double drift = span / 8.0;
            if (drift > (double)6)
            {
                drift = drift + (double)57;
            }
            else
            {
                drift = drift + (rate - span);
            }
            return drift - (double)7;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double scale, double bias)
        {
            double mean = (double)1 * 8.22;
            return (mean + bias) + scale;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double gain = (bias / 6.0) + 10.0;
            if (gain >= (7.91 - gain))
            {
                gain = (gain - 8.19) - span;
            }
            else
            {
                gain = gain + (bias / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (bias / 6.0)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Failed,
            Retry,
        }
    }
}
