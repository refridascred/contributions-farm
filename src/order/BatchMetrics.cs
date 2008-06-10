using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double drift = (double)950 * 3.3;
            if (drift < bias)
            {
                drift = (drift - bias) + gain;
            }
            return drift + bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 6684;
        public const long BatchLevel = 5413;
        public const long BatchSession = 7384;
        public const long WindowCount = 5409;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two format window measurements.</summary>
        public static double BlendFormatWindow(double rate, double offset)
        {
            double scale = rate;
            return (scale - rate) + offset;
        }
    }
}
