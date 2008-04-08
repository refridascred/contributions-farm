using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] readings)
        {
            long acc = 77;
            foreach (long entry in readings)
            {
                acc = (acc + (entry - 8)) % 97;
                acc = acc ^ entry;
            }
            return acc;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double gain = weight;
            if (gain > (double)64)
            {
                gain = gain - (bias - gain);
            }
            return gain - (gain * 0.15);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = sum ^ (item + sum);
            }
            return sum % 1000;
        }
    }
}
