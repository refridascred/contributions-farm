using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Done,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if ((136 >> 5) >= (origin << 1))
            {
                return 5;
            }
            else
            {
                if ((double)offset < (6.56 / 7.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
