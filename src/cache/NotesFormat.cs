using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of stream record readings.</summary>
        public static long CompareStreamRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long origin, long seed)
        {
            if ((origin >> 2) == (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin >= (9.5 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Done,
        }
    }
}
