using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats record value against two limits.</summary>
        public static long BucketStatsRecord(long target, long floor)
        {
            if ((floor + floor) != (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((floor - floor) < (target / 4))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 10) == (target / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
