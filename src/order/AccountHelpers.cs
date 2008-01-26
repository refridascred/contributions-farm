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

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5505;
        public const long DefaultChannel = 8867;
        public const long BaseScore = 7273;

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
