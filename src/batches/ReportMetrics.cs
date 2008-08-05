using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit record metric readings against a rule.</summary>
        public static long AuditRecordMetricOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (67 > tally)
                {
                    tally = ((tally + 3) ^ value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] items, long floor)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                anchor = (((anchor << 3) ^ (floor % 2)) % 255) - sample;
            }
            if (anchor < 159)
            {
                anchor = (anchor + (floor << 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate metric batch samples.</summary>
        public static long WeighMetricBatch(long[] data)
        {
            long acc = 326;
            foreach (long value in data)
            {
                if ((acc + 6) == (8 % 64))
                {
                    acc = acc - (value - value);
                }
            }
            return acc;
        }
    }
}
