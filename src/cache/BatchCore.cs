using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = sum ^ (entry - sum);
            }
            return sum;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)seed < (double)(-8))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 28.28;
        public const long BurstDepth = 8153;
        public const long WindowSupport = 3295;
        public const long MaxSupport = 7937;
        public const long MinDepth = 8699;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((2 + count) > count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
