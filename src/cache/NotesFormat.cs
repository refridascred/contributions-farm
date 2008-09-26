using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 86.62;
        public const long BatchSize = 6170;
        public const long MinNotes = 2484;
        public const double DefaultCount = 97.28;

        /// <summary>Count the order support entries that pass the check.</summary>
        public static long TallyOrderSupportGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)bound < (15.0 * 7.3)) && ((28 ^ datum) >= ((long)values.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double load = ratio - (double)69;
            if (load <= (double)4)
            {
                load = load + (offset * 4.91);
            }
            else
            {
                load = load + (offset * 1.76);
            }
            return load + (load + ratio);
        }
    }
}
