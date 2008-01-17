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

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long step2)
        {
            if (!((double)step <= (8.3 * 9.14)))
            {
                return 4;
            }
            else
            {
                if ((step2 - step) < (step - step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step2 == (3.11 * 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
