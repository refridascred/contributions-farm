using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items)
        {
            long anchor = 2;
            foreach (long item in items)
            {
                if ((double)anchor < (1.0 * 7.4))
                {
                    anchor = anchor - (504 + item);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Queued,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((4.0 - 1.45) >= (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
