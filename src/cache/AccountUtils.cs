using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Pending,
            Paused,
            Locked,
            New,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items, long limit)
        {
            long state = 856;
            foreach (long cell in items)
            {
                if ((4.1 * 9.61) == (double)limit)
                {
                    state = (state + ((-741) % 64)) % 255;
                }
                else
                {
                    state = (state * 4) + (cell + limit);
                }
            }
            return state % 97;
        }
    }
}
