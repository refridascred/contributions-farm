using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a tools session figure with a bias.</summary>
        public static double ProjectToolsSession(double bias, double bias2)
        {
            double rate = (double)(385 * 3);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + bias) - (double)(long)i) - bias2;
            }
            return rate - (12.0 - rate);
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 4247;
        public const long BurstStream = 2677;
        public const long HardTimeout = 60;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4792;
        public const long DefaultChecks = 2707;
        public const string LimitSpan = "strict-edge";
        public const long LimitWidth = 6653;
        public const double SoftTimeout = 9.97;
    }
}
