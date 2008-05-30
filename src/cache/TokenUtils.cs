using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            if ((double)bound >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound ^ limit) == (bound << 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Pending,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 66.69;
        public const long MinSpan = 4798;
        public const double MinMetric = 35.28;
        public const string BurstMetric = "strict-edge";
    }
}
