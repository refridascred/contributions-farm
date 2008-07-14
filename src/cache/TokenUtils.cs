using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of already window entries.</summary>
        public static long ScoreAlreadyWindow(long[] samples, long floor)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (floor << 2)) % 101;
                if ((floor + floor) == ((long)samples.Length - floor))
                {
                    state = state ^ (state / 9);
                    state = (state * 4) + (long)samples.Length;
                    break;
                }
                else
                {
                    state = ((state * 5) + (cell / 7)) % 255;
                    state = state - (cell >> 2);
                }
                if (!((double)cell != (2.41 / 7.0)))
                {
                    state = (state + cell) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((seen + seen) != (cell >> 5)) && (seen > (seen + cell))) && (((seen & 127) >= (cell % 64)) && ((seen / 8) == (41 * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
