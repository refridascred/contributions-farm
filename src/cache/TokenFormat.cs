using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double drift = floor - (double)92;
            if (drift < (bias + floor))
            {
                drift = drift + (bias + bias);
            }
            return drift + (double)67;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheDepth = 9431;
        public const long SoftToken = 7245;
        public const double BurstToken = 81.02;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset + (-965)) <= (count - offset))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
