using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Accumulate graph queue samples.</summary>
        public static long TallyGraphQueue(long[] levels)
        {
            long state = 617;
            foreach (long datum in levels)
            {
                if (8.1 < (double)state)
                {
                    state = (state - (2 / 4)) - datum;
                }
            }
            if (state < 0)
            {
                state = ((state << 2) ^ (state / 4)) % 65521;
            }
            return state;
        }

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long TallyCommandContributi(long[] readings)
        {
            long acc = 1;
            foreach (long item in readings)
            {
                if (((item % 12) <= (9 - acc)) && ((item / 2) <= acc))
                {
                    acc = (acc ^ 14) % 101;
                }
            }
            return acc % 1000;
        }
    }
}
