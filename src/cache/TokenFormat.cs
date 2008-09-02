using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches / 9) < (matches - target))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state + ((-3) ^ state);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitBudget = "staging";
        public const long HardInterval = 4451;
        public const long BatchSpan = 8284;
    }
}
