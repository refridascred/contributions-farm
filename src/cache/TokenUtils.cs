using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 4417;
        public const long HardTimeout = 3068;
        public const long LimitBuffer = 418;
        public const double RetryLevel = 46.62;
        public const string IdleBuffer = "stable-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 1639;
        public const long IdleRatio = 8662;
        public const double BaseCount = 48.36;
        public const long SoftSpan = 7856;

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long bound)
        {
            if ((double)offset != (4.26 * 5.7))
            {
                return 6;
            }
            else
            {
                if ((bound ^ offset) > bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
