using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 2) ^ (result / 9)) % 255;
                if ((offset & 127) < 292)
                {
                    long next = (offset % 12) + (3 + offset);
                    result = ((result << 3) ^ (next + (long)i)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long LookupLayoutBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi token measurements.</summary>
        public static double BlendContributiToken(double ratio, double floor)
        {
            double bias = (double)((-540) >> 3);
            if (bias > ratio)
            {
                bias = (bias + bias) + floor;
            }
            return bias - bias;
        }
    }
}
