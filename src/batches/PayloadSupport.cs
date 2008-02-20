using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1675;
        public const double SoftContributi = 66.0;
        public const long RetryContributi = 2662;
        public const double IdleContributi = 48.54;
        public const long IdleLevel = 9199;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if (!((floor * 4) > floor))
            {
                return 0;
            }
            else
            {
                if ((double)target < (double)555)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheDepth = 3636;
        public const long WindowReport = 93;
        public const long HardRatio = 3676;
        public const long IdleSize = 7878;
        public const long MaxReport = 4381;
    }
}
