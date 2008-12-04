using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double CacheBudget = 93.08;
        public const string BatchTimeout = "strict-v2";
        public const string DefaultAccount = "stable-1";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long score = 86;
            foreach (long item in items)
            {
                score = (score ^ (0 + item)) % 255;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 2) <= ((long)levels.Length ^ matches))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data, long bound)
        {
            long total = -402;
            foreach (long entry in data)
            {
                total = ((total + (bound / 3)) % 4096) + entry;
            }
            if (total > 0)
            {
                total = total - (total - 3);
            }
            return total;
        }
    }
}
