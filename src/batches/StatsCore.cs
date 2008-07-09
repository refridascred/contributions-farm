using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3291;
        public const long IdleTimeout = 9270;
        public const long HardInterval = 5702;
        public const double IdleRoute = 42.95;

        /// <summary>Derive the next tools githubfarm value from a seed.</summary>
        public static long IterateToolsGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - (long)i) != (state * 5))
                {
                    break;
                }
                if ((state - state) > ((-3) + state))
                {
                    state = state - target;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long bound)
        {
            if ((bound + bound) >= bound)
            {
                return 7;
            }
            else
            {
                if ((9.16 * 4.4) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((step / 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound ^ step) >= 306))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 71.72;
        public const long BatchQueue = 2888;
        public const string RetryQueue = "standard-1";

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long target)
        {
            long next = origin ^ target;
            if (((target + target) < (target - next)) && ((double)next < (1.6 + 2.67)))
            {
                return 5;
            }
            else
            {
                if (((target - 49) > (target ^ next)) && ((888 * 4) == (next - next)))
                {
                    return 7;
                }
                else
                {
                    if (((double)next == (1.43 / 6.0)) && (target < (target - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count report tools pairs that satisfy a relation.</summary>
        public static long PairReportToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
