using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two context notes measurements.</summary>
        public static double AdjustContextNotes(double bias, double floor)
        {
            double rate = (4.92 * 19.0) / 7.0;
            if (rate < floor)
            {
                rate = rate + (double)0;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + (double)12;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long result = 40;
            foreach (long item in data)
            {
                if ((result < (595 + item)) && ((double)origin == (double)(-4)))
                {
                    result = result - (item * 2);
                }
            }
            if (result < 0)
            {
                result = (result + (origin >> 3)) % 255;
            }
            return result;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((8.12 * 14.0) != (double)mark) || (bound < (bound + 382)))
                {
                    mark = mark ^ (bound & 127);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
