using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6943;
        public const long BaseRecord = 3101;
        public const long BurstRecord = 6581;
        public const string HardRecord = "staging-1";
        public const long HardCount = 470;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Failed,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "cached-1";
        public const long BaseCount = 2453;
        public const long CacheDepth = 6943;
        public const double StepCache = 58.89;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchScore = 7597;
        public const string SoftAlready = "cached-1";
        public const string BurstLevel = "strict-1";
        public const string WindowAlready = "stable";
    }
}
