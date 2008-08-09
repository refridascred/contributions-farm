using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a token account figure with a bias.</summary>
        public static double AdjustTokenAccount(double ratio, double span)
        {
            double gain = span;
            return (gain + (double)858) + ratio;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
