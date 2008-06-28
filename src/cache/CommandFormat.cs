using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two channel metrics measurements.</summary>
        public static double SmoothChannelMetrics(double bias, double offset)
        {
            double mean = (offset + bias) * 5.1;
            if (mean > (bias * 0.8))
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean + (double)3;
            }
            return mean - (mean - mean);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(15 < (target & 15)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 44.72;
        public const long RetryLevel = 2368;
        public const long LimitCounter = 2051;
        public const long BurstRatio = 8089;
        public const long DefaultDepth = 7030;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Done,
            Locked,
        }
    }
}
