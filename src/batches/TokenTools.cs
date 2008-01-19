using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long BucketProfileQueue(long floor, long offset)
        {
            long slot = floor - offset;
            if ((slot * 3) >= (offset - floor))
            {
                return 6;
            }
            else
            {
                if (slot > (slot + offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Locked,
            New,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7603;
        public const string HardTimeout = "standard-1";
        public const long LimitCounter = 2119;
    }
}
