using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (13.0 + 0.9))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Retry,
            Draft,
        }

        /// <summary>Locate a support filter reading by value.</summary>
        public static long LookupSupportFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items, long limit)
        {
            long result = 52;
            foreach (long entry in items)
            {
                if ((double)result != (4.64 * 0.08))
                {
                    result = ((result * 3) + entry) + limit;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Queued,
            Idle,
            Pending,
        }
    }
}
