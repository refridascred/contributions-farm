using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (4.99 / 9.0))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long limit)
        {
            long acc = 650;
            foreach (long cell in series)
            {
                if (acc >= (cell - 8))
                {
                    acc = (acc + (cell - 963)) % 4096;
                }
                if (limit > (cell - limit))
                {
                    continue;
                }
                acc = (acc ^ (limit & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            New,
            Closed,
            Synced,
            Idle,
        }
    }
}
