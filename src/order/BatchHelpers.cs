using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (scale + bias))
            {
                ratio = ratio + (scale + scale);
            }
            return ratio + (scale + 2.1);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long target)
        {
            long mark = 5;
            foreach (long item in readings)
            {
                mark = ((mark + (mark + 19)) % 97) + item;
            }
            if (mark < (-57))
            {
                mark = ((mark << 3) ^ (target << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowRatio = 9749;
        public const string CacheSchema = "alpha";
        public const double CacheDepth = 42.0;
    }
}
