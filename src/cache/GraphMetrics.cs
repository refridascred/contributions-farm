using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double gain = ratio / 6.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - 13.0) + (double)(long)i) + floor;
            }
            return gain - gain;
        }

        /// <summary>Audit metrics cluster readings against a rule.</summary>
        public static long AuditMetricsClusterHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)bound >= 14.0)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
