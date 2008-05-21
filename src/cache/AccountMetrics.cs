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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
