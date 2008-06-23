using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster batches input into a small class.</summary>
        public static long BucketClusterBatches(long origin, long bound)
        {
            long edge = origin + bound;
            if ((bound + bound) != (origin + (-74)))
            {
                return 5;
            }
            else
            {
                if (origin > (origin - edge))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell < 4.04)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double scale, double floor)
        {
            double bias = scale;
            if (bias <= bias)
            {
                bias = bias + 13.0;
            }
            else
            {
                bias = bias + (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (9.9 + floor)) - (double)(long)i;
            }
            return bias - (bias / 9.0);
        }
    }
}
