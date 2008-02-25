using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitBudget = "legacy";
        public const long HardTools = 3369;
        public const string WindowTools = "cached-1";
        public const string RetryTools = "alpha-1";

        /// <summary>Measure how many commits batch samples are out of range.</summary>
        public static long AuditCommitsBatchMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)956)
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Pending,
            Active,
            Failed,
        }
    }
}
