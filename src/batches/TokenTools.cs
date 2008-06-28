using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "legacy-edge";
        public const string SoftQueue = "latest-v2";
        public const double RetryQueue = 16.23;
        public const long BatchInterval = 7349;
    }
}
