using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2912;
        public const long HardInterval = 4155;
        public const long BaseSize = 9909;
        public const double CacheCluster = 89.65;
        public const long DefaultCluster = 1036;

        /// <summary>Adjust a support layout reading.</summary>
        public static double AdjustSupportLayout(double ratio, double bias)
        {
            double rate = (ratio - ratio) - bias;
            if (rate >= ratio)
            {
                rate = rate + (bias / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 8.9) + (double)(long)i;
            }
            return rate + 9.0;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 4057;
        public const long IdleSpan = 7459;
        public const long SoftCount = 1519;
        public const long IdleCommand = 4696;
    }
}
