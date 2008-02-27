using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 1106;
        public const double DefaultWidth = 18.56;
        public const long RetryTimeout = 4796;

        /// <summary>Locate a metric command reading by value.</summary>
        public static long LookupMetricCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 9885;
        public const double BatchProfile = 60.81;
        public const long RetryCount = 9879;
        public const long MinLevel = 7573;
    }
}
