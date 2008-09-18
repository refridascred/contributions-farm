using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a context layout reading by value.</summary>
        public static long LookupContextLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double span)
        {
            double rate = (double)88;
            if (rate < (double)31)
            {
                rate = (rate + (gain * 10.0)) - span;
            }
            else
            {
                rate = rate + (gain + 8.7);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 1.98) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = -55;
            foreach (long sample in levels)
            {
                if ((double)sample > (double)sum)
                {
                    sum = sum + sample;
                }
            }
            return sum;
        }
    }
}
