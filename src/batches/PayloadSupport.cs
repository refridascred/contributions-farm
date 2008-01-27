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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (6 >= seed)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
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
