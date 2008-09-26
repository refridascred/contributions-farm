using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + 34) != (item % 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                if ((state ^ step) > (state + state))
                {
                    state = (state ^ (46 + state)) % 4096;
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
