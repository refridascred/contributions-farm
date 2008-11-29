using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchRatio = "alpha-1";
        public const long RetryReport = 7676;
        public const long SoftFactor = 9682;
        public const double DefaultReport = 22.58;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value != (2.85 - 1.0))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
