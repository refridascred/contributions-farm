using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue order readings against a rule.</summary>
        public static long TallyQueueOrderHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) == (cell & 255))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
