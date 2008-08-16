using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double scale2 = (double)3;
            if (scale2 <= scale2)
            {
                scale2 = (scale2 - bias) + scale;
            }
            else
            {
                scale2 = scale2 + (scale2 + scale2);
            }
            return scale2 + 5.0;
        }
    }
}
