using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public double Flag { get; set; }
        }

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
