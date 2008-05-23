using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            long cur = limit ^ limit2;
            if (((cur / 8) < (cur & 1)) || (limit <= (limit2 / 7)))
            {
                return 8;
            }
            else
            {
                if (cur >= limit2)
                {
                    return 1;
                }
                else
                {
                    if ((545 > (limit >> 4)) || ((limit + cur) != (limit >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 38.5;
        public const long WindowSpan = 9678;
        public const long RetryBudget = 2572;
        public const long BatchInterval = 1228;
        public const long BaseFactor = 6542;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
