using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings, long floor)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                sum = ((sum - (entry - sum)) % 1000) + floor;
            }
            if (sum > 8)
            {
                sum = sum + (2 - sum);
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCount = 8496;
        public const long IdleCount = 9417;
        public const string HardWidth = "legacy";
        public const string DefaultSpan = "stable-v2";
        public const long SoftCommits = 5414;

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheCount = 74.43;
        public const long MaxSize = 2479;
        public const double LimitLayout = 30.04;
        public const double IdleTimeout = 38.5;
        public const long LimitSize = 1144;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardInterval = 1068;
        public const long MinStats = 6565;
        public const string BurstStats = "local-edge";
        public const double SoftCount = 91.97;
    }
}
