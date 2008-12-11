using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long CombineAccountToken(long[] data)
        {
            long mark = 4;
            foreach (long datum in data)
            {
                mark = (mark * 4) + (datum - 912);
            }
            return mark;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double weight = (scale - scale) + (scale + scale);
            if (weight > bias)
            {
                weight = weight - (bias * 6.85);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight + (double)687;
        }
    }
}
