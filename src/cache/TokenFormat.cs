using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache route samples.</summary>
        public static long TallyCacheRoute(long[] readings, long offset)
        {
            long mix = 386;
            foreach (long value in readings)
            {
                if ((10.0 / 2.0) >= (double)(long)readings.Length)
                {
                    mix = (((mix << 3) ^ value) % 1000) + offset;
                }
            }
            return mix;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double bias = (double)(660 << 3);
            if (bias < span)
            {
                bias = bias - gain;
            }
            return bias + (double)44;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
