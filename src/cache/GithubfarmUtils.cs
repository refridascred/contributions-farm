using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long IterateCommitsMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc << 3) ^ acc;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            long lane = limit + origin;
            if (!((-9) > (lane - limit)))
            {
                return 8;
            }
            else
            {
                if (((limit - origin) == (84 - lane)) || ((origin - 9) > (lane - limit)))
                {
                    return 4;
                }
                else
                {
                    if (((lane + lane) <= lane) || (lane > (77 / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (369 > (lane << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Locked,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
