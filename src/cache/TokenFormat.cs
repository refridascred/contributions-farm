using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 9293;
        public const long LimitSize = 1872;
        public const string MinContributi = "legacy";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            long lane = floor ^ step;
            if (6.4 <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (((double)lane > 7.18) && (step >= (12 & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((step - lane) > (step - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
