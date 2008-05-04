using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8924;
        public const double IdleCluster = 79.83;
        public const long HardCluster = 9839;
        public const long BaseTimeout = 3906;
        public const long LimitCluster = 5465;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long bound2)
        {
            if ((bound2 + bound) <= (bound * 4))
            {
                return 4;
            }
            else
            {
                if (!((double)bound2 <= (double)bound))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum & 7) < (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
