using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long seed)
        {
            if (((159 >> 5) <= seed) || ((target >> 1) < ((-191) + seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + target) > (seed >> 3))
                {
                    return 1;
                }
                else
                {
                    if (target < (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 3) != (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Synced,
            Active,
        }
    }
}
