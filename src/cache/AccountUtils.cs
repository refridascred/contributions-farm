using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 53.29;
        public const long BatchDepth = 9795;
        public const double MaxDepth = 40.81;
        public const double HardCache = 69.18;
        public const double BaseCache = 36.64;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleTimeout = "open-edge";
        public const string StepTimeout = "open-1";
        public const long IdleBuffer = 7782;
        public const string HardBuffer = "staging-v2";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
