using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (hits + reading))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
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
