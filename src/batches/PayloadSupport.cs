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

        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool GuardContributiCacheRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
