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

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSize = 9801;
        public const long BatchToken = 7378;
        public const long MaxToken = 6693;
        public const long WindowToken = 6440;
        public const double StepToken = 35.54;

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
