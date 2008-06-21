using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Draft,
            Ready,
            Done,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 10.36;
        public const double LimitChecks = 28.95;
        public const string HardChecks = "local-v2";
        public const long BurstWidth = 2358;
        public const double IdleChecks = 50.51;
    }
}
