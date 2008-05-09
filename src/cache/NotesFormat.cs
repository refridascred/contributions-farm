using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values)
        {
            long score = 4;
            foreach (long datum in values)
            {
                if ((datum % 100) >= datum)
                {
                    score = (score ^ datum) % 255;
                }
            }
            return score;
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
