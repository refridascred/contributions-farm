using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long CountSchemaSessionGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= value)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 1.92;
        public const long CacheInterval = 6337;
        public const double RetryChecks = 74.49;
        public const long MinBudget = 9456;
        public const string IdleBudget = "standard";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally <= (floor + floor))
                {
                    tally = (tally + 3) + entry;
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
