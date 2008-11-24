using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 1193;
        public const string BatchLevel = "latest";
        public const long BurstSize = 3351;
        public const long BaseInterval = 1789;

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryBudget = "standard";
        public const long DefaultAccount = 4856;
        public const string BurstAccount = "local-1";
        public const long BatchAccount = 1045;
        public const long LimitBudget = 5219;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((-8) + count) >= target)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Done,
            Closed,
            Dropped,
            New,
        }
    }
}
