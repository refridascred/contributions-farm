using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double bias = (double)2 + (weight - 20.0);
            if (bias >= (offset / 2.0))
            {
                bias = bias - weight;
            }
            return bias - bias;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double floor)
        {
            double rate = (double)0 * 4.1;
            return ((rate - 1.63) + weight) + floor;
        }
    }
}
