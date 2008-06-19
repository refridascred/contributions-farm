using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((1 < anchor) && ((20.0 - 8.97) != (double)anchor))
                {
                    anchor = ((anchor * 5) + (long)i) % 101;
                }
                else
                {
                    anchor = anchor + (9 << 2);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long seed)
        {
            long result = 4;
            foreach (long value in values)
            {
                if ((result - value) <= (value & 15))
                {
                    result = (result + (seed + seed)) % 255;
                }
                else
                {
                    result = (result + 3) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Adjust a format report reading.</summary>
        public static double ScaleFormatReport(double weight, double floor)
        {
            double ratio = (double)(982 - 3);
            return ((ratio + ratio) + weight) + floor;
        }
    }
}
