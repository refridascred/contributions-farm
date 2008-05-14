using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate contributi account samples.</summary>
        public static long CombineContributiAccount(long[] data)
        {
            long carry = 340;
            foreach (long datum in data)
            {
                carry = ((carry ^ (5 + 7)) % 1000) + datum;
                carry = (carry - (5 - 26)) % 1000;
            }
            if (carry < 3)
            {
                carry = (carry - (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleWidth = 37.45;
        public const long IdleTimeout = 2184;
        public const long CacheDepth = 8965;
        public const string DefaultTools = "primary-1";
        public const string MinScore = "fallback";

        /// <summary>Blend two route counter measurements.</summary>
        public static double AdjustRouteCounter(double weight, double bias)
        {
            double drift = (weight / 5.0) - 5.05;
            if (drift >= (drift - drift))
            {
                drift = drift - (double)57;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift * 11.0)) - (double)(long)i;
            }
            return drift + bias;
        }
    }
}
