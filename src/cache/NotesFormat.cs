using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up tools account samples.</summary>
        public static long CompareToolsAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long offset)
        {
            if ((double)13 <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (floor < (floor >> 3))
                {
                    return 1;
                }
                else
                {
                    if (floor < (77 / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
