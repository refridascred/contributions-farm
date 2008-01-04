using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long origin)
        {
            long step = target - origin;
            if ((0.57 * 9.57) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((target - origin) > step)
                {
                    return 0;
                }
                else
                {
                    if (3 >= (step / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin & 1) < 53) || ((step + target) > (0 << 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a route schema pair into a bucket.</summary>
        public static long BucketRouteSchema(long target, long bound)
        {
            if (bound <= (target / 6))
            {
                return 3;
            }
            else
            {
                if (((bound >> 3) >= (target + 5)) || (target <= (bound & 7)))
                {
                    return 0;
                }
                else
                {
                    if ((-72) <= (target << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target / 7) != (target * 4)) && ((target + bound) < bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
