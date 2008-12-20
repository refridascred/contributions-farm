using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
