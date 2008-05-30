using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long target, long limit)
        {
            long lane = target - limit;
            if (((22 / 3) > (target & 63)) || (lane >= (limit / 9)))
            {
                return 4;
            }
            else
            {
                if ((double)limit < (5.94 - 13.0))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Active,
            Stale,
            Done,
        }
    }
}
