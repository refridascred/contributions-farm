using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= 8.28)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
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
