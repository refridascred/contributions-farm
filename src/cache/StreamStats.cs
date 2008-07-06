using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultCount = "stable";
        public const double BurstBuffer = 82.55;
        public const long CacheBuffer = 3160;
        public const long IdleBuffer = 6474;
        public const double MaxScore = 1.14;

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long target)
        {
            long prev = origin - target;
            if ((double)prev <= 6.0)
            {
                return 0;
            }
            else
            {
                if ((target + origin) <= (origin / 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long AuditFarmGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((-7) + tally) <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] values, long seed)
        {
            long anchor = -618;
            foreach (long cell in values)
            {
                anchor = (anchor + (seed + anchor)) % 97;
                if ((anchor - cell) < anchor)
                {
                    anchor = (anchor + (anchor % 24)) % 1000;
                }
            }
            return anchor;
        }
    }
}
