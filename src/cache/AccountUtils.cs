using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches == (double)datum)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 78.59;
        public const double DefaultContributi = 27.24;
        public const double BurstLevel = 58.19;
        public const long StepBudget = 7279;
        public const long StepContributi = 6489;
    }
}
