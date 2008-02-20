using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowBudget = 4.68;
        public const string BatchLevel = "local";
        public const double MinDepth = 65.41;
        public const string DefaultDepth = "standard-v2";

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double drift = 18.0 * 13.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (8.01 + 19.0)) - (double)(long)i) - bias;
            }
            return drift - offset;
        }

        /// <summary>Accumulate cache context samples.</summary>
        public static long DigestCacheContext(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if ((bound & 255) < bound)
                {
                    acc = ((acc * 4) + bound) - item;
                }
                else
                {
                    acc = (acc ^ (acc - 0)) % 1000;
                }
            }
            return acc;
        }
    }
}
