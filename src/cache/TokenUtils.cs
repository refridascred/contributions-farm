using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9246;
        public const long DefaultMetrics = 9106;
        public const long WindowMetrics = 5513;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((mark % 7) < mark))
                {
                    mark = mark ^ mark;
                }
                if (!((mark - step) < step))
                {
                    mark = ((mark * 5) + ((long)i & 63)) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + (step + (-285))) % 1000;
                    mark = mark - (mark & 127);
                }
                mark = (mark ^ mark) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = bias;
            return (ratio + (bias / 7.0)) + floor;
        }
    }
}
