using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleCount = 3125;
        public const long CacheSize = 8568;
        public const string DefaultInterval = "primary";
        public const long CacheTimeout = 887;
        public const long BurstCount = 7257;

        /// <summary>Fold a list of metric channel readings.</summary>
        public static long CombineMetricChannel(long[] series, long floor)
        {
            long result = 28;
            foreach (long datum in series)
            {
                result = (((result * 2) + (result + result)) % 255) - floor;
                result = ((result * 4) + datum) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                if ((double)sum == (double)item)
                {
                    sum = (sum ^ (sum / 5)) % 97;
                }
            }
            return sum;
        }
    }
}
