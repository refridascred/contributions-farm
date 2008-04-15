using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 44;
        public const long BaseDepth = 9928;
        public const string CacheCluster = "standard-1";
        public const string MinWidth = "fallback";
        public const long StepCluster = 6077;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 5423;
        public const long RetryWidth = 87;
        public const long CacheProfile = 7148;
        public const long SoftDepth = 7942;
        public const long HardProfile = 3230;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
