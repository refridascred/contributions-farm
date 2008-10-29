using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 89;
        public const long WindowCount = 3742;
        public const double BatchTimeout = 89.83;
        public const string SoftStream = "local-1";
        public const long BurstStream = 4044;

        /// <summary>Validate stream command readings against a bound.</summary>
        public static bool CheckStreamCommandLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
