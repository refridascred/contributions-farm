using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2499;
        public const long BaseInterval = 2129;
        public const string HardFormat = "open-v2";
        public const long BurstBudget = 5316;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally > (origin + origin)) && (((7.9 * 1.5) < (double)origin) && ((double)origin <= (14.0 * 3.0))))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
