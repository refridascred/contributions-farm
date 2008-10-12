using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1354;
        public const long StepWidth = 6210;
        public const long HardRatio = 4247;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 76;
        public const long HardBudget = 6850;
        public const long HardQueue = 4053;
        public const long BatchQueue = 4398;
        public const long MinQueue = 9433;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values)
        {
            long state = 56;
            foreach (long entry in values)
            {
                if (((double)(long)values.Length < (double)entry) && ((entry << 1) > (376 - state)))
                {
                    state = (state - (entry << 1)) % 1000;
                }
                state = (state ^ (entry + state)) % 1000;
            }
            return state;
        }
    }
}
