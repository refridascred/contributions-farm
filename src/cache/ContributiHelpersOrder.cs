using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long state = 80;
            foreach (long datum in values)
            {
                if (!((state % 97) > (datum ^ (long)values.Length)))
                {
                    state = state ^ datum;
                }
                if (!((datum ^ state) == (datum * 3)))
                {
                    state = ((state << 3) ^ (datum / 4)) % 97;
                }
                else
                {
                    state = ((state * 2) + (state >> 5)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSpan = 4990;
        public const double StepBudget = 67.86;
        public const string MinNotes = "staging-v2";
        public const double HardTimeout = 17.15;
        public const long MaxNotes = 8388;
    }
}
