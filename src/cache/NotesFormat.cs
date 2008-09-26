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

        /// <summary>Adjust a window stats reading.</summary>
        public static double AdjustWindowStats(double bias, double offset)
        {
            double drift = bias;
            return (drift + 1.9) + offset;
        }
    }
}
