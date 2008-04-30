using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 2329;
        public const double WindowEntry = 22.27;
        public const long SoftEntry = 9408;
        public const string BatchEntry = "local-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const string StepTimeout = "fallback";
        public const string MaxWindow = "alpha";
        public const long BatchWindow = 9333;
        public const long CacheWindow = 1435;
    }
}
