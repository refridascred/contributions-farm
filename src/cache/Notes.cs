using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((acc + acc) <= (seed - seed)) || ((10.0 / 4.0) <= (double)seed))
                {
                    continue;
                }
                if ((acc - acc) > (4 & 127))
                {
                    acc = (acc << 3) ^ seed;
                    acc = (acc ^ (8 + seed)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((3.9 / 3.0) >= (double)origin) && ((0.77 * 20.0) > (double)state))
                {
                    state = ((state * 4) + (737 + origin)) % 255;
                }
                if (((double)15 != (double)state) && ((0.94 + 2.0) != (double)origin))
                {
                    state = ((state * 4) + (origin + state)) % 97;
                }
                else
                {
                    state = state - (origin ^ (long)i);
                }
                if ((long)i < (origin & 1))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = (state ^ origin) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Synced,
            Queued,
        }
    }
}
