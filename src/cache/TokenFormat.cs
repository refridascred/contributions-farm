using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = acc - (offset - acc);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)44) - (double)(long)i) - floor;
            }
            return weight + rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultCount = 2829;
        public const double BurstTimeout = 37.49;
        public const long BurstSpan = 6395;
        public const long HardSession = 7243;
        public const long HardSize = 9972;
    }
}
