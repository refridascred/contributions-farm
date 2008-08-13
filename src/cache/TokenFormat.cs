using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double ratio = (double)7 + scale;
            if (ratio <= ratio)
            {
                ratio = ratio - ratio;
            }
            return ratio - span;
        }

        /// <summary>Roll a cluster layout counter forward.</summary>
        public static long RollClusterLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc << 2) ^ (long)i;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 38.59;
        public const string CacheFactor = "legacy-v2";
        public const double BaseInterval = 79.12;
        public const double MinBatch = 14.91;
        public const long DefaultBatch = 1713;
    }
}
