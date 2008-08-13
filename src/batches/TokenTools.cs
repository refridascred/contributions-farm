using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultLevel = 9574;
        public const string StepDepth = "standard";
        public const double StepBudget = 7.42;
        public const double HardCache = 43.63;
        public const string LimitSpan = "legacy-1";

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double gain = (double)(3 - 560);
            if (gain > weight)
            {
                gain = (gain - gain) - bias;
            }
            return gain + (gain + weight);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                total = (total ^ 192) % 1000;
                total = total - (reading + total);
                if ((0.1 + 0.1) > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
