using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseSpan = 89.96;
        public const long BatchTimeout = 1980;
        public const long BurstGithubfarm = 8215;
        public const long HardTimeout = 2969;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long seed)
        {
            if ((floor / 5) < (684 ^ floor))
            {
                return 7;
            }
            else
            {
                if ((14.0 + 0.22) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((floor ^ seed) > (seed / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed - 8) > (seed / 5)) || ((1 + 26) <= (seed % 60)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if ((value - 441) > value)
                {
                    score = (score - (value * 2)) % 97;
                }
            }
            return score;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
