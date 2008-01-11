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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
