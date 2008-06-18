using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
