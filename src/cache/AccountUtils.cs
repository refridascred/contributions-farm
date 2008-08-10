using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of cache stream readings.</summary>
        public static long MatchCacheStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if ((floor - target) == (floor / 6))
            {
                return 5;
            }
            else
            {
                if ((1.79 + 1.0) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches == (double)(-27))
                {
                    matches = ((matches + 1) - cell) - origin;
                }
            }
            return matches;
        }
    }
}
