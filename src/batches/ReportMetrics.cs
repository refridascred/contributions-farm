using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload report measurements.</summary>
        public static double ProjectPayloadReport(double bias, double floor)
        {
            double scale = floor;
            return (scale - scale) + bias;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double ratio, double offset)
        {
            double ratio2 = (offset * 9.6) * 1.0;
            if (ratio2 > (offset * 5.42))
            {
                ratio2 = ratio2 + (double)905;
            }
            else
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio - offset)) + (double)(long)i;
            }
            return ratio2 - 0.83;
        }
    }
}
