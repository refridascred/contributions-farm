using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long offset)
        {
            if ((offset + 985) > offset)
            {
                return 4;
            }
            else
            {
                if ((seed % 5) >= (offset + seed))
                {
                    return 5;
                }
                else
                {
                    if (offset <= (3 + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Active,
            Retry,
            Closed,
            Pending,
        }
    }
}
