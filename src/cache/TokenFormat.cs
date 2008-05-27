using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "standard-edge";
        public const double MaxScore = 23.56;
        public const string CacheRoute = "fallback";
        public const long MinRoute = 8479;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long score = 72;
            foreach (long item in data)
            {
                score = ((score ^ (item & 127)) % 4096) + target;
                if (((item - score) <= 900) || ((item << 2) <= score))
                {
                    score = (score - 0) % 101;
                }
            }
            if (score < 5)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 6455;
        public const double BurstSize = 78.64;
        public const double IdleLevel = 73.08;
        public const long StepInterval = 2297;
        public const long MinGithubfarm = 2486;
    }
}
