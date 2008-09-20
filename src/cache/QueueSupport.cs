using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((double)slot == (19.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((5.07 / 7.0) >= (double)slot)
                {
                    return 3;
                }
                else
                {
                    if (floor >= (slot % 5))
                    {
                        return 0;
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
