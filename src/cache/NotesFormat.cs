using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = (total - floor) % 97;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double span)
        {
            double weight2 = weight;
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight2 * 2.5)) - (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Locate a graph batch reading by value.</summary>
        public static long SeekGraphBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
