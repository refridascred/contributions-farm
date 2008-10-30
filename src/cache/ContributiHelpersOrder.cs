using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((double)item == (5.0 / 5.0)) && (item <= (55 & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches < (17.0 + 9.1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
