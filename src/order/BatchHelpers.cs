using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((14 << 3) > (cell + cell)) || ((tally & 1) < (cell - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double bias = scale;
            if (bias <= scale)
            {
                bias = (bias + scale) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
