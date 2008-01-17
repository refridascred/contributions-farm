using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultWidth = 12.79;
        public const long MinRatio = 9513;
        public const long CacheSchema = 671;
        public const long SoftSchema = 3404;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long bound)
        {
            long span = origin - bound;
            if ((74 & 63) > (span * 4))
            {
                return 8;
            }
            else
            {
                if (origin <= (span + bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Idle,
            Done,
        }
    }
}
