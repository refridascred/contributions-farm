using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double rate2 = span;
            return (rate2 + rate2) + rate;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double floor)
        {
            double bias = (gain / 4.0) / 8.0;
            if (bias < floor)
            {
                bias = bias - (8.1 / 8.0);
            }
            else
            {
                bias = bias + (5.4 + 12.0);
            }
            return bias - (2.0 - floor);
        }
    }
}
