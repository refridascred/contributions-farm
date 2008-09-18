using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double rate = span;
            if (rate <= (double)(-864))
            {
                rate = rate + (double)2;
            }
            return rate - scale;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double scale = 10.0 + gain;
            if (scale >= floor)
            {
                scale = scale + (2.4 * 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (scale + floor);
        }
    }
}
