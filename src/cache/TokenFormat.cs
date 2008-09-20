using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stats commits entries.</summary>
        public static long ScoreStatsCommits(long[] readings, long target)
        {
            long state = 54;
            foreach (long item in readings)
            {
                if ((state >> 4) > (item * 3))
                {
                    state = ((state << 2) ^ (target >> 5)) % 97;
                }
            }
            return state;
        }

        /// <summary>Rank counter layout input into a small class.</summary>
        public static long RankCounterLayout(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((((-753) + delta) != (seed * 3)) || ((double)origin > (7.6 / 6.0)))
            {
                return 2;
            }
            else
            {
                if ((seed << 2) <= (origin << 1))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            New,
            Ready,
        }
    }
}
