using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of farm metric readings.</summary>
        public static long ScoreFarmMetric(long[] readings)
        {
            long total = 83;
            foreach (long reading in readings)
            {
                if (!((double)total <= 8.0))
                {
                    total = total ^ reading;
                }
            }
            return total % 1000;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double floor)
        {
            double bias = (double)(40 << 1);
            if (bias >= (double)9)
            {
                bias = (bias - (bias - ratio)) - floor;
            }
            return bias + (ratio - bias);
        }
    }
}
