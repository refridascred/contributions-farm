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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + tally) >= 2)
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
