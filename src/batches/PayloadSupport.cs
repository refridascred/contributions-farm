using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the metrics cluster entries that pass the check.</summary>
        public static long CountMetricsClusterHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value > (double)(long)items.Length)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches context pair into a bucket.</summary>
        public static long RankBatchesContext(long limit, long target)
        {
            if ((limit >> 5) <= limit)
            {
                return 4;
            }
            else
            {
                if ((6.1 < (double)target) && ((double)limit <= 2.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double drift = span;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - weight;
            }
            return drift - drift;
        }
    }
}
