using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (6.95 + 5.36))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 4169;
        public const string BatchCache = "open";
        public const long BurstLevel = 9075;
        public const double DefaultCache = 34.06;
        public const double BurstBudget = 35.11;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseFactor = "standard-edge";
        public const long HardSize = 8925;
        public const string BurstChecks = "open-v2";
    }
}
