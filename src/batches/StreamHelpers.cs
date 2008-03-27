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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + count) <= (datum - count))
                {
                    count = count + 2;
                }
            }
            return count;
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
