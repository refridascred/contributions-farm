using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] items)
        {
            long anchor = 57;
            foreach (long value in items)
            {
                if ((double)anchor < 5.67)
                {
                    anchor = ((anchor << 3) ^ (value * 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double scale = (double)(440 / 6);
            if (scale < (span + bias))
            {
                scale = scale - (span / 3.0);
            }
            return scale + bias;
        }
    }
}
