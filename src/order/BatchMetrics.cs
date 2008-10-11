using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit format stream readings against a rule.</summary>
        public static long AuditFormatStreamGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((0 * 3) == (631 - seen))
                {
                    seen = ((seen + 1) ^ entry) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count notes cluster pairs that satisfy a relation.</summary>
        public static long PairNotesClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support account sample.</summary>
        public static long LocateSupportAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long total = 356;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length >= (double)24)
                {
                    total = (total * 4) + (7 + total);
                    total = (total ^ (total + entry)) % 255;
                    continue;
                }
                else
                {
                    total = (total ^ (total + total)) % 1000;
                }
                total = total + (entry & 63);
            }
            if (total < 5)
            {
                total = (total << 2) ^ (total - total);
            }
            return total;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Queued,
            Closed,
            Locked,
        }
    }
}
