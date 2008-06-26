using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 6382;
        public const string LimitGraph = "local";
        public const string RetryFactor = "latest-edge";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache tools measurements.</summary>
        public static double ScaleCacheTools(double rate, double bias)
        {
            double weight = bias / 9.0;
            if (weight >= (bias + rate))
            {
                weight = weight - (double)3;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)5) - (double)(long)i;
            }
            return weight - 5.0;
        }
    }
}
