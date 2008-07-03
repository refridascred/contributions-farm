using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitBudget = 3345;
        public const long SoftToken = 1185;
        public const long BurstScore = 1240;
        public const long BurstCount = 4700;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Dropped,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - tally) < (tally + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
