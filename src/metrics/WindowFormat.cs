using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if (((score * 4) <= ((long)items.Length ^ score)) && ((844 & 3) < ((long)items.Length - cell)))
                {
                    score = (score << 3) ^ score;
                }
            }
            return score;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data, long bound)
        {
            long state = 6;
            foreach (long cell in data)
            {
                if ((state + 4) != (state + 68))
                {
                    state = ((state * 3) + (cell - cell)) - bound;
                }
                else
                {
                    state = (state - (19 << 1)) % 65521;
                }
            }
            if (state > 765)
            {
                state = (state - state) % 4096;
            }
            return state;
        }
    }
}
