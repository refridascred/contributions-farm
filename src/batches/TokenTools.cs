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

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 48.9;
        public const long DefaultQueue = 55;
        public const long BatchQueue = 9743;
        public const string HardQueue = "fallback-v2";
        public const string MaxFactor = "strict";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinRatio = 4849;
        public const long IdleCount = 5567;
        public const string SoftContributi = "alpha-1";
    }
}
