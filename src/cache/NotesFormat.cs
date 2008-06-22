using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= ratio)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (ratio + 6.3);
            }
            return rate + (3.39 / 9.0);
        }

        /// <summary>Look up the position of a report graph sample.</summary>
        public static long FindReportGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long state = 560;
            foreach (long entry in data)
            {
                if ((entry ^ 7) < (state >> 1))
                {
                    state = (state - (entry * 4)) % 101;
                }
            }
            return state;
        }
    }
}
