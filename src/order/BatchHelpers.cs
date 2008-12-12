using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double drift = weight;
            return (drift + 8.7) + floor;
        }

        /// <summary>Classify a cluster commits pair into a bucket.</summary>
        public static long BucketClusterCommits(long target, long origin)
        {
            long delta = target + origin;
            if ((delta + target) > target)
            {
                return 5;
            }
            else
            {
                if ((double)origin < 9.41)
                {
                    return 2;
                }
                else
                {
                    if (origin <= (target & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (delta <= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
