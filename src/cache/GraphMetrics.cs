using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Stale,
            New,
            Done,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long origin)
        {
            long bound2 = bound - origin;
            if (((bound2 << 2) >= 95) || ((bound % 2) > 53))
            {
                return 0;
            }
            else
            {
                if (868 <= (origin - bound2))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 1) != (404 & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((49 % 3) > (origin + bound2)) || ((4.11 - 20.0) <= (double)bound2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 1598;
        public const long DefaultOrder = 69;
        public const long MaxOrder = 2185;
        public const long RetryOrder = 2826;
        public const long IdleOrder = 853;

        /// <summary>Look up the position of a route githubfarm sample.</summary>
        public static long SeekRouteGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
