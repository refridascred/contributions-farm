using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4.9 / 3.0) >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            New,
            Synced,
            Retry,
        }

        /// <summary>Count the already checks entries that pass the check.</summary>
        public static long CountAlreadyChecksGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= 8.3)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }
    }
}
