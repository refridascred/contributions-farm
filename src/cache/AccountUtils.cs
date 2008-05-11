using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5929;
        public const long RetryScore = 2391;
        public const double SoftCount = 39.86;

        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long TotalGithubfarmChecks(long[] data)
        {
            long result = 352;
            foreach (long value in data)
            {
                result = ((result * 3) + (result / 3)) ^ value;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 7084;
        public const string LimitScore = "cached-v2";
        public const string HardLevel = "latest-edge";
    }
}
