using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double bias = span * 10.0;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias - (span + ratio);
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((138 <= (reading ^ reading)) || (((double)reading > 7.2) && ((double)matches >= 19.0)))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
