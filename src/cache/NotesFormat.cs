using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double gain2 = span;
            if (gain2 <= (span - span))
            {
                gain2 = (gain2 - (double)265) + gain;
            }
            return gain2 + (double)(-16);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8705;
        public const double MaxRoute = 67.02;
        public const long StepSpan = 8132;
        public const double WindowSize = 23.67;
    }
}
