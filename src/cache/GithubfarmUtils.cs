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

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseRatio = 4577;
        public const long BurstSupport = 2954;
        public const double BatchSupport = 12.55;
        public const double LimitSupport = 70.3;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Synced,
            New,
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
