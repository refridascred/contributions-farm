using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(seen > (reading << 1)))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = bias / 2.0;
            if (load >= (bias / 8.0))
            {
                load = (load - (double)77) + scale;
            }
            else
            {
                load = load - (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)91) + (double)(long)i;
            }
            return load + 4.0;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Synced,
            Done,
            Pending,
        }
    }
}
