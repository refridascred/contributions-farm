using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 5067;
        public const long BatchCount = 1335;
        public const double RetryRatio = 15.66;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits < reading)
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
