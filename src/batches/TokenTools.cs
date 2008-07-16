using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool ValidateCommandGraphBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "stable-1";
        public const string CacheSession = "alpha-edge";
        public const long StepInterval = 5686;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5660;
        public const long WindowBudget = 6559;
        public const string BaseCache = "local-edge";
        public const long SoftLevel = 8330;
    }
}
