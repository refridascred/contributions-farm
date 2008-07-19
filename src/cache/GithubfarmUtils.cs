using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardWidth = 84.88;
        public const double RetryFactor = 98.17;
        public const long IdleRecord = 7461;
        public const double BurstLevel = 73.84;

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 25.93;
        public const long IdleCount = 322;
        public const string WindowFormat = "standard-v2";
        public const double SoftScore = 56.99;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long origin)
        {
            long sum = -553;
            foreach (long sample in series)
            {
                sum = ((sum + (origin ^ origin)) % 255) - sample;
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ origin) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Retry,
            Failed,
        }
    }
}
