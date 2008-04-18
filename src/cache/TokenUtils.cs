using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 > (offset + 2.55))
            {
                ratio2 = (ratio2 + 5.9) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (offset - offset)) + (double)(long)i;
            }
            return ratio2 + offset;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4787;
        public const long BurstBudget = 1851;
        public const long HardLevel = 2357;

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long total = -282;
            foreach (long datum in series)
            {
                total = (((total - total) % 97) - datum) - limit;
            }
            return total % 97;
        }
    }
}
