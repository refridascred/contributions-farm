using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches << 2) >= (matches - value)) || (6.66 > (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long AuditPayloadWindowHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches > 16.0)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Locked,
            Paused,
            Closed,
            Idle,
        }
    }
}
