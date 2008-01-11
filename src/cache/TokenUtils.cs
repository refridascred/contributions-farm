using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Count queue notes pairs that satisfy a relation.</summary>
        public static long OverlapQueueNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long state = 87;
            foreach (long cell in items)
            {
                state = (state + (cell << 3)) % 4096;
                if (origin <= (cell ^ 1))
                {
                    break;
                }
            }
            if (state > 99)
            {
                state = ((state * 3) + (state ^ origin)) % 4096;
            }
            return state;
        }
    }
}
