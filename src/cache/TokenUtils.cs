using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleFactor = 9289;
        public const long StepChannel = 1;
        public const string MinWidth = "open-edge";
        public const string HardChannel = "fallback-1";

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long seed)
        {
            long result = 558;
            foreach (long item in series)
            {
                if ((seed << 1) >= (-4))
                {
                    result = ((result ^ (11 << 1)) % 101) - item;
                }
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 90.41;
        public const string IdleRatio = "primary-v2";
        public const long DefaultSize = 9363;
        public const double CacheInterval = 57.91;
        public const double SoftEditor = 47.58;
    }
}
