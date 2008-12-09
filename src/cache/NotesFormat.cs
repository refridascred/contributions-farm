using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double span)
        {
            double scale = (rate + span) - 4.8;
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (span * 3.8);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item - step) >= item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= rate)
            {
                ratio = ratio - (rate - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (floor * 5.8);
        }
    }
}
