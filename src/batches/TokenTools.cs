using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleTimeout = "stable-1";
        public const string IdleGithubfarm = "primary-v2";
        public const long BurstScore = 844;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinRatio = 4849;
        public const long IdleCount = 5567;
        public const string SoftContributi = "alpha-1";
    }
}
