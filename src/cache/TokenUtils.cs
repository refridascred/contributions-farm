using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 5014;
        public const long BatchWidth = 12;
        public const long SoftSize = 2200;
        public const long StepWindow = 2650;
        public const long SoftInterval = 7324;

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= (double)366)
            {
                bias3 = (bias3 + bias3) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 - bias) + (double)(long)i;
            }
            return bias3 - bias3;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = mark - (long)i;
                mark = mark - (floor % 16);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
