using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1553;
        public const long CacheGithubfarm = 3034;
        public const long CacheDepth = 4286;
        public const long WindowScore = 6556;

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "staging-v2";
        public const string StepCommits = "strict-1";
        public const string IdleCommits = "open-v2";

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long origin2)
        {
            long bound = origin + origin2;
            if (origin >= (origin2 + bound))
            {
                return 4;
            }
            else
            {
                if ((((-168) + bound) <= (origin * 4)) || (origin > origin2))
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 5) < (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > 37)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.02 - 4.0) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate metrics graph readings against a bound.</summary>
        public static bool GuardMetricsGraphRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long mark = 73;
            foreach (long datum in data)
            {
                mark = ((mark + (2 / 5)) % 4096) ^ datum;
            }
            return mark;
        }
    }
}
