using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 76;
        public const long HardBudget = 6850;
        public const long HardQueue = 4053;
        public const long BatchQueue = 4398;
        public const long MinQueue = 9433;

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long state = 603;
            foreach (long reading in levels)
            {
                state = ((state * 5) + (reading << 1)) % 101;
                if (!((bound - state) > (state + bound)))
                {
                    state = state - bound;
                }
                else
                {
                    state = state ^ reading;
                }
            }
            return state;
        }
    }
}
