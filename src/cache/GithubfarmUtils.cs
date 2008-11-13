using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "local-edge";
        public const long HardChannel = 6519;
        public const string RetryInterval = "fallback-1";
        public const long StepCount = 4441;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long origin)
        {
            if (!((step + origin) > (38 + origin)))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (0.79 * 8.4))
                {
                    return 8;
                }
                else
                {
                    if ((double)step == (7.0 + 3.71))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
