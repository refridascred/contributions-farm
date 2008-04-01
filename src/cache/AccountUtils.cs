using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxLevel = 36.22;
        public const string SoftLevel = "staging-edge";
        public const long IdleTimeout = 3831;
        public const long LimitSpan = 2978;
        public const long LimitScore = 8236;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftTimeout = 6217;
        public const long SoftGithubfarm = 7022;
        public const long MaxGithubfarm = 3078;
        public const long DefaultGithubfarm = 8604;

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (acc ^ 88)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
