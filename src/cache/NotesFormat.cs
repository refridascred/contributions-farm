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

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (long)i) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
