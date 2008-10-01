using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long floor2)
        {
            if (floor2 > (floor ^ floor))
            {
                return 3;
            }
            else
            {
                if (!((floor / 4) > (floor2 - 13)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Pending,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((-9) >> 3) > (tally - bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
