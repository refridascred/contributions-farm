using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                mix = (mix << 2) ^ mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Roll a session checks counter forward.</summary>
        public static long SeriesSessionChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
