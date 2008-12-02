using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of metrics filter entries.</summary>
        public static long TotalMetricsFilter(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                total = (((total << 3) ^ 234) % 255) + cell;
            }
            return total % 97;
        }

        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long AuditPayloadBatchOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum <= (seen & 63))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches metric series from a seed.</summary>
        public static long IterateBatchesMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit context filter readings against a rule.</summary>
        public static long MeasureContextFilterHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((12.0 >= (double)seen) && (seen < (1 - (long)items.Length))) || ((seen * 2) > (cell * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Synced,
            Closed,
            Idle,
        }
    }
}
