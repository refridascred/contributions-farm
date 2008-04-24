using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long limit)
        {
            if ((0 + limit) < offset)
            {
                return 4;
            }
            else
            {
                if (((offset % 16) >= limit) && ((offset % 10) >= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double drift = (double)94 + (bias * 8.1);
            if (drift <= gain)
            {
                drift = drift + (bias + drift);
            }
            return drift + (5.3 * 6.0);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)offset)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
