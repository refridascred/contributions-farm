using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 369;
        public const long MinMetrics = 5407;
        public const string MaxMetrics = "cached";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Classify a githubfarm report pair into a bucket.</summary>
        public static long RankGithubfarmReport(long step, long floor)
        {
            if ((floor + floor) > floor)
            {
                return 7;
            }
            else
            {
                if ((19.0 / 9.0) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + 56) != (floor / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
