using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "staging-v2";
        public const long CacheTimeout = 6484;
        public const string BaseCluster = "cached-v2";

        /// <summary>Count the account payload entries that pass the check.</summary>
        public static long CountAccountPayloadOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value << 3) >= hits)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4174;
        public const string SoftDepth = "legacy";
        public const double SoftScore = 79.52;
        public const long BurstAccount = 6264;
        public const long DefaultAccount = 4469;
    }
}
