using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 4288;
        public const double BurstRatio = 58.89;
        public const long LimitDepth = 4515;
        public const string BurstSize = "fallback-1";

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
