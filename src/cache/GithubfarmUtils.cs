using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxLevel = 9490;
        public const double IdleRatio = 56.79;
        public const long MaxMetric = 7384;
        public const long CacheMetric = 4516;

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 41.11;
        public const long HardOrder = 1557;
        public const long StepOrder = 3627;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
