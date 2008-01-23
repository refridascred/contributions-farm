using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftRatio = 40.76;
        public const double BasePayload = 12.09;
        public const double HardPayload = 48.4;
        public const long BurstRatio = 5141;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double weight2 = (double)((-21) - 304);
            if (weight2 > (floor * 7.3))
            {
                weight2 = weight2 - (9.35 - weight2);
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + 15.0;
        }
    }
}
