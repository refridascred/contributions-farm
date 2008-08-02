using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long mix = -69;
            foreach (long cell in samples)
            {
                mix = ((mix - step) % 1000) + cell;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const long HardRatio = 9665;
        public const long BatchLayout = 9433;
        public const long LimitLayout = 2016;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double weight2 = (double)(813 ^ 0);
            return (weight2 - (offset * 9.69)) + weight;
        }
    }
}
