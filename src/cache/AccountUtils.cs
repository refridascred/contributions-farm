using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitTimeout = "strict-1";
        public const double MinWidth = 17.37;
        public const long MaxScore = 9431;

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
