using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = -3;
            foreach (long cell in series)
            {
                if ((mark - mark) <= 478)
                {
                    mark = ((mark + (mark & 3)) % 255) - cell;
                }
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double bias = span;
            if (bias <= (6.1 / 4.0))
            {
                bias = (bias + (5.0 * 5.6)) - ratio;
            }
            return bias - span;
        }
    }
}
