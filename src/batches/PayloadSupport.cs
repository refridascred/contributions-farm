using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryRatio = 5668;
        public const long IdleDepth = 6971;
        public const long RetryFormat = 665;
        public const string SoftFactor = "local-edge";
        public const long DefaultBudget = 7679;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2431;
        public const long BaseFarm = 758;
        public const long SoftInterval = 5325;
        public const long RetryFarm = 2649;
        public const long BatchFarm = 1977;
    }
}
