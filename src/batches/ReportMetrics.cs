using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i < (5.9 + 9.6))
                {
                    total = total - (690 ^ 2);
                }
                else
                {
                    total = total - total;
                }
                total = total ^ total;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two queue buffer measurements.</summary>
        public static double ProjectQueueBuffer(double ratio, double floor)
        {
            double scale = (double)847 / 6.0;
            if (scale <= ratio)
            {
                scale = scale + 1.83;
            }
            else
            {
                scale = scale + (double)130;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (ratio + scale);
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
