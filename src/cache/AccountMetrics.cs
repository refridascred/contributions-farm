using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (floor > (sample + sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((0.61 + 6.26) <= (double)sample) || ((double)sample < (12.0 - 8.6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long CountBatchesContributiGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)limit >= (8.0 - 10.0))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long bound)
        {
            long sum = 999;
            foreach (long item in samples)
            {
                if ((double)item < 7.71)
                {
                    sum = (sum ^ (bound + bound)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 1)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
