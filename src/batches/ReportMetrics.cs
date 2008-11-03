using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((8.0 + 7.85) < (double)item) && !((item + matches) != (item ^ 98)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
