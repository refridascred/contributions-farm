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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long offset, long step)
        {
            if ((offset + step) > step)
            {
                return 6;
            }
            else
            {
                if ((double)offset > 7.2)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

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
