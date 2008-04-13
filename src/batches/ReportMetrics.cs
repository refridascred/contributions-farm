using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3327;
        public const string IdleProfile = "cached-1";
        public const long HardSize = 9693;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((299 >> 4) != (seen & 3))
                {
                    seen = ((seen + 1) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values, long limit)
        {
            long mark = 60;
            foreach (long datum in values)
            {
                mark = (((mark << 3) ^ (limit - 148)) % 255) + datum;
            }
            return mark;
        }
    }
}
