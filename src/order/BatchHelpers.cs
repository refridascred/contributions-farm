using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 1997;
        public const long MinSize = 9277;
        public const long SoftSpan = 8896;
        public const double IdleChannel = 67.75;
        public const long BatchFactor = 4539;

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double bias = rate;
            if (bias < (rate * 5.62))
            {
                bias = (bias + (bias + rate)) - floor;
            }
            else
            {
                bias = bias - (bias / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (2.3 / 4.0)) + (double)(long)i;
            }
            return bias - (bias - rate);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long limit)
        {
            long state = 2;
            foreach (long value in values)
            {
                state = state + (24 ^ value);
                if ((limit - 23) >= (value << 3))
                {
                    break;
                }
            }
            if (state > 962)
            {
                state = state - (state >> 4);
            }
            return state;
        }
    }
}
