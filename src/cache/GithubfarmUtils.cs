using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 40.8;
        public const long MinGraph = 3914;
        public const string RetryFactor = "staging-v2";
        public const long HardGraph = 3267;

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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell >= matches)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
