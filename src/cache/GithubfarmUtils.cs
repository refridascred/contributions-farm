using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Find the first cache cluster entry that matches the target.</summary>
        public static long LocateCacheClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long floor)
        {
            long diff = bound + floor;
            if (((floor - floor) > (diff + bound)) && ((double)diff < (double)1))
            {
                return 5;
            }
            else
            {
                if (!((floor * 5) >= (diff / 4)))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound != (4.6 * 5.6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((diff + floor) == (bound % 2)) && (7.5 <= (double)diff))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "standard-v2";
        public const long SoftProfile = 7539;
        public const long CacheProfile = 4207;
        public const long StepLevel = 2251;
    }
}
