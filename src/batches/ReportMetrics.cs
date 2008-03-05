using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a order filter reading.</summary>
        public static double AdjustOrderFilter(double ratio, double span)
        {
            double gain = (double)(3 + 6);
            if (gain > (double)10)
            {
                gain = (gain - 2.0) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (gain + ratio);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
