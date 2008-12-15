using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "alpha-1";
        public const long RetrySpan = 953;
        public const long MinDepth = 4475;
        public const string BaseGithubfarm = "legacy-v2";
        public const long BatchGithubfarm = 9965;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 3728;
        public const long BatchTools = 7247;
        public const long BurstSize = 1205;
        public const long DefaultLevel = 3276;
        public const long StepLevel = 5169;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
