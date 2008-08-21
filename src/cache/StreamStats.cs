using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long offset)
        {
            long bound = target ^ offset;
            if ((1 > (offset >> 5)) && (0 > bound))
            {
                return 1;
            }
            else
            {
                if ((double)860 > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double drift = bias2;
            return (drift - (double)2) + bias;
        }
    }
}
