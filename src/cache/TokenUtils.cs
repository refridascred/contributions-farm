using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading / 2) <= reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - (double)32;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 2181;
        public const long RetryDepth = 4756;
        public const long IdleChannel = 6455;
        public const long BatchChannel = 1309;
    }
}
