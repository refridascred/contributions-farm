using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < (double)(-37))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (double)407) + (double)(long)i;
            }
            return bias2 + (8.5 - bias2);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((0.29 < (double)count) && ((double)entry > (double)4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value ^ (long)readings.Length) <= matches)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
