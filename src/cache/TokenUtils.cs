using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheBudget = 204;
        public const string DefaultCount = "standard-edge";
        public const double BurstInterval = 16.21;

        /// <summary>Define already limits and defaults.</summary>
        public const string HardRatio = "standard-edge";
        public const long BatchAlready = 7604;
        public const long IdleSize = 2371;
        public const double CacheSpan = 11.23;
        public const long StepAlready = 4865;
    }
}
