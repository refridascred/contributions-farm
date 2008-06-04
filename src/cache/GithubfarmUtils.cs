using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long offset, long seed)
        {
            long delta = offset - seed;
            if ((delta * 4) >= seed)
            {
                return 4;
            }
            else
            {
                if ((seed & 15) <= 91)
                {
                    return 3;
                }
                else
                {
                    if ((delta + 5) > (seed & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed < (2.8 - 9.65))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
