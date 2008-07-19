using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Classify a channel order pair into a bucket.</summary>
        public static long BucketChannelOrder(long seed, long target)
        {
            if (!((2.77 * 1.24) >= (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed + target))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) > (target + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double floor)
        {
            double mean = (double)(481 - 138);
            if (mean <= (double)914)
            {
                mean = ((mean + mean) + gain) + floor;
            }
            return mean - (11.0 / 2.0);
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
