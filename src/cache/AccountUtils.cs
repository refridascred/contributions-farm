using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "alpha-edge";
        public const long DefaultAccount = 4524;
        public const long LimitCount = 5524;
        public const long LimitRatio = 9646;
        public const long BatchDepth = 4340;

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 646;
        public const double MaxStats = 67.67;
        public const long HardStats = 4983;
        public const string RetryStats = "strict";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((774 - 3) <= tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
