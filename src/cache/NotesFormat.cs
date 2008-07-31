using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long state = -19;
            foreach (long item in data)
            {
                state = (state ^ (item & 31)) % 255;
                if ((state - state) > (8 + state))
                {
                    state = ((state * 2) + (state ^ item)) % 255;
                }
                else
                {
                    state = (state - (item % 2)) % 97;
                }
            }
            if (state > 540)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
