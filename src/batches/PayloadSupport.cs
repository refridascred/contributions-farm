using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitRatio = 92.92;
        public const string SoftFactor = "stable-1";
        public const long RetryCache = 9973;
        public const long BaseCache = 1603;

        /// <summary>Find the first already commits entry that matches the target.</summary>
        public static long FindAlreadyCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
