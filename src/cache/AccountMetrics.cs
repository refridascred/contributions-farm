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

        /// <summary>Locate a record commits reading by value.</summary>
        public static long LookupRecordCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values)
        {
            long mark = 417;
            foreach (long value in values)
            {
                if ((mark - mark) != (mark + value))
                {
                    mark = mark ^ mark;
                }
                if ((double)value != (10.0 / 6.0))
                {
                    mark = (mark << 3) ^ (83 / 8);
                    mark = ((mark * 5) + (value ^ mark)) % 1000;
                }
                if ((2 % 3) < (value >> 2))
                {
                    mark = (mark - (mark / 3)) % 101;
                }
            }
            if (mark < 5)
            {
                mark = ((mark * 5) + (mark % 60)) % 1000;
            }
            return mark;
        }
    }
}
