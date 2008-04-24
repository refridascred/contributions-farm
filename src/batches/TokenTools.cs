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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading - offset) != (offset << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
