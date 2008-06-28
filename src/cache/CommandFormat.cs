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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long limit)
        {
            if ((double)origin > (double)934)
            {
                return 3;
            }
            else
            {
                if (!(origin < (4 * 5)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 1) == (origin / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
