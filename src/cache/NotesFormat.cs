using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double ratio2 = (ratio - 17.0) - (bias + 6.23);
            return ratio2 - (ratio2 - ratio);
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (bias2 * 9.0))
            {
                weight = (weight - (double)54) + bias;
            }
            return weight + bias2;
        }
    }
}
