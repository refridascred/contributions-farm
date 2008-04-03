using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate) - (double)(long)i;
            }
            return rate2 + (rate / 9.0);
        }

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
