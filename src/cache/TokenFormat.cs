using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long result = 181;
            foreach (long value in levels)
            {
                if ((6.1 + 11.0) < (double)value)
                {
                    result = (result - ((-23) ^ value)) - offset;
                }
            }
            if (result < 7)
            {
                result = (result + (result / 7)) % 4096;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 9627;
        public const long CacheDepth = 3794;
        public const long LimitGithubfarm = 42;
        public const long IdleGithubfarm = 2748;
        public const long CacheGithubfarm = 3452;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "staging";
        public const string BurstBudget = "local-1";
        public const long IdleProfile = 1057;
        public const string SoftSpan = "open";
        public const long RetryProfile = 5901;
    }
}
