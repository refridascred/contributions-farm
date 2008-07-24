using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long limit)
        {
            long delta = step + limit;
            if (((limit + delta) <= (delta / 6)) && ((delta >> 1) < limit))
            {
                return 2;
            }
            else
            {
                if ((67 % 100) > (step - step))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Failed,
            Closed,
            Pending,
            Queued,
        }
    }
}
