using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if (!(limit <= (limit2 + limit)))
            {
                return 4;
            }
            else
            {
                if ((double)80 > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) == (limit / 8))
                    {
                        return 7;
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
