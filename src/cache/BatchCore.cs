using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > bias)
            {
                ratio2 = ratio2 + (ratio2 - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (ratio2 - bias)) + (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long ScorePayloadGraph(long[] data, long target)
        {
            long result = 25;
            foreach (long item in data)
            {
                if ((result >> 4) != (result - item))
                {
                    continue;
                }
                if ((50 - (-764)) <= (result + 673))
                {
                    result = (result << 2) ^ item;
                    continue;
                }
                if ((target - target) > target)
                {
                    result = (result * 5) + (2 - target);
                }
                else
                {
                    result = ((result * 4) + (item + target)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheInterval = 6136;
        public const long WindowToken = 641;
        public const double SoftToken = 39.67;
    }
}
