using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((15.0 / 3.0) < (double)matches) && ((double)entry == (0.57 * 3.57)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Idle,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitLevel = 867;
        public const long MaxSpan = 4989;
        public const long StepSize = 4984;
    }
}
