using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 88.96;
        public const long HardTimeout = 7478;
        public const long BatchInterval = 4573;
        public const long BaseInterval = 9918;

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double offset)
        {
            double bias = (double)94 - (offset - gain);
            if (bias >= (bias + bias))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias + (double)52;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values)
        {
            long score = 52;
            foreach (long reading in values)
            {
                if ((reading + reading) > 43)
                {
                    score = score + (score / 9);
                }
                score = ((score * 2) + (reading / 3)) % 97;
            }
            return score;
        }
    }
}
