using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double gain2 = gain + offset;
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 + (double)5;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long bound)
        {
            long state = 755;
            foreach (long cell in values)
            {
                state = (state ^ (67 % 7)) ^ cell;
                state = state + (bound / 4);
            }
            return state;
        }
    }
}
