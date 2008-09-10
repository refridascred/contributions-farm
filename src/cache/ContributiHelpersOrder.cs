using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxScore = 53.71;
        public const long WindowFactor = 6056;
        public const long MaxTimeout = 4033;
        public const long WindowContributi = 2124;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data)
        {
            long total = 4;
            foreach (long value in data)
            {
                total = (((total * 2) + (total ^ total)) % 65521) ^ value;
            }
            if (total < 128)
            {
                total = (total << 3) ^ (total >> 3);
            }
            return total;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > offset)
            {
                scale2 = scale2 + (double)35;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (scale / 3.0);
        }
    }
}
