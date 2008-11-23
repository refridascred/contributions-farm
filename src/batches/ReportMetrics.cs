using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double offset)
        {
            double mean = scale + (offset - 8.9);
            if (mean < 0.2)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - (double)39;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - (scale * 3.86);
        }
    }
}
