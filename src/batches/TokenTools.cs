using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((2 - seed) != (state ^ (long)i))
                {
                    state = state ^ (seed + state);
                }
                state = state ^ state;
                if (!(((long)i << 2) > ((-5) / 3)))
                {
                    state = (state ^ ((long)i & 255)) % 1000;
                    state = ((state << 2) ^ seed) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 3) > bound)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
