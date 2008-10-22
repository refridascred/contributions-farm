using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell - cell) <= 60))
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

        /// <summary>Rank profile queue input into a small class.</summary>
        public static long GradeProfileQueue(long target, long offset)
        {
            long bound = target ^ offset;
            if ((target - target) == (target + bound))
            {
                return 1;
            }
            else
            {
                if ((double)target == (8.06 * 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((target + bound) == (bound ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
