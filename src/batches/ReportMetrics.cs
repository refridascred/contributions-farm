using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 7716;
        public const double MaxCount = 7.19;
        public const long LimitToken = 1013;

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
