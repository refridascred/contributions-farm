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

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
