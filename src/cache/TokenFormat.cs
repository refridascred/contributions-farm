using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Draft,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Match up session editor samples.</summary>
        public static long MatchSessionEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((13.0 * 7.6) <= (double)tally)
                {
                    tally = ((tally + 1) + cell) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
