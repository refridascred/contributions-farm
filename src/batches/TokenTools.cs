using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "standard-edge";
        public const string IdleGraph = "strict";
        public const long CacheBudget = 3639;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 15.27;
        public const long BaseChecks = 9643;
        public const string RetryChecks = "stable-1";
    }
}
