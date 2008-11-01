using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            long gap = target - origin;
            if (origin >= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((gap / 4) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            long step = limit - offset;
            if ((46 + step) > (limit + 40))
            {
                return 4;
            }
            else
            {
                if ((15.0 <= (double)limit) || ((limit % 64) >= 3))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step >= (11.0 - 8.7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset & 63) >= (-8)) && ((limit << 1) < (17 - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Idle,
            Retry,
            Closed,
        }
    }
}
