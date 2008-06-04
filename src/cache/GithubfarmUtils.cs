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

        /// <summary>Accumulate filter contributi samples.</summary>
        public static long ScoreFilterContributi(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = (anchor - (entry - anchor)) % 255;
                if ((anchor ^ entry) < (3 * 5))
                {
                    anchor = (anchor - (entry >> 2)) % 4096;
                }
            }
            return anchor;
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
