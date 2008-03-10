using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "stable";
        public const long HardTimeout = 3865;
        public const double BurstDepth = 3.91;
        public const long IdleFilter = 7049;
        public const string WindowFilter = "standard";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits >= (5.0 + 5.0))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Pending,
            Closed,
            New,
        }
    }
}
