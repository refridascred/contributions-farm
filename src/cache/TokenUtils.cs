using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "local-edge";
        public const long BurstFactor = 2658;
        public const long BatchDepth = 3729;
        public const long DefaultDepth = 2030;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long seed)
        {
            if (!(seed > (origin - seed)))
            {
                return 5;
            }
            else
            {
                if (((12.0 / 3.0) <= (double)seed) && (seed >= (seed << 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
