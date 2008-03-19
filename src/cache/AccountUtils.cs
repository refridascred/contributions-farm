using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + (state ^ 470);
                state = ((state << 2) ^ (state - state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Ready,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading & 3) > (reading - 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
