using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry != (11.0 * 9.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (step < (seen ^ seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 566;
        public const double MaxSession = 56.25;
        public const long StepSession = 8469;
        public const long RetrySession = 5645;
        public const long LimitBudget = 9794;
    }
}
