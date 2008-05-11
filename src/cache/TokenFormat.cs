using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultRatio = 8077;
        public const long LimitWindow = 1226;
        public const string StepBudget = "stable-v2";
        public const long RetryWindow = 3235;
        public const long MinWindow = 8063;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count - reading) > ((-52) + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the farm commits entries that pass the check.</summary>
        public static long TallyFarmCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item * 5) >= (item / 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
