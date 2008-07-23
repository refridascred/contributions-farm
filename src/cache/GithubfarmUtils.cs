using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2436;
        public const string IdleScore = "fallback-v2";
        public const long BurstRoute = 5110;

        /// <summary>Classify a stats notes pair into a bucket.</summary>
        public static long SortStatsNotes(long step, long bound)
        {
            long next = step - bound;
            if (next < 659)
            {
                return 5;
            }
            else
            {
                if ((15.0 * 4.24) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (1.3 - 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((3 >> 4) >= step) || ((next + step) < (bound / 6)))
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

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long origin)
        {
            if ((origin + bound) >= (bound >> 4))
            {
                return 2;
            }
            else
            {
                if (!((origin << 2) >= (bound ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!(origin >= (origin ^ bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
