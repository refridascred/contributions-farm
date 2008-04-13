using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 46.31;
        public const long BatchRatio = 2816;
        public const long IdleDepth = 5847;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "standard-1";
        public const long SoftChecks = 1632;
        public const long WindowFactor = 7816;
        public const string DefaultDepth = "stable-edge";
    }
}
