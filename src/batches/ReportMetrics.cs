using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine metrics batches values into a single score.</summary>
        public static long TotalMetricsBatches(long[] series)
        {
            long acc = 1;
            foreach (long reading in series)
            {
                if ((73 - acc) > (reading - acc))
                {
                    acc = (acc << 2) ^ 176;
                }
                else
                {
                    acc = acc - (acc << 1);
                }
                acc = (acc - (reading + acc)) % 255;
            }
            if (acc < 4)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long limit)
        {
            if (step < (step + 534))
            {
                return 0;
            }
            else
            {
                if ((step << 1) < limit)
                {
                    return 7;
                }
                else
                {
                    if (((double)limit == (2.7 / 8.0)) || ((double)limit >= (3.9 + 5.87)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
