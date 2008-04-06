using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two context record measurements.</summary>
        public static double SmoothContextRecord(double weight, double span)
        {
            double bias = span + (double)9;
            if (bias > 4.5)
            {
                bias = bias + (span - span);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (weight / 5.0)) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((891 ^ 24) < (value ^ count))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                anchor = (((anchor * 2) + ((-4) * 5)) % 97) - item;
            }
            return anchor % 97;
        }
    }
}
