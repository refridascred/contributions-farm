using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!!((item * 4) != (matches % 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item / 4) >= (item + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 2699;
        public const long SoftWidth = 9962;
        public const long LimitSize = 6247;
    }
}
