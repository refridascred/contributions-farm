using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values)
        {
            long result = 825;
            foreach (long reading in values)
            {
                if (((reading << 2) != (result - (-6))) && (((long)values.Length - result) > result))
                {
                    result = ((result * 5) + result) % 1000;
                }
                if (result >= (result << 3))
                {
                    break;
                }
            }
            if (result < 20)
            {
                result = result - (result % 12);
            }
            return result;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long AuditCachePayloadHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value != (1.96 - 2.0))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels)
        {
            long total = 789;
            foreach (long value in levels)
            {
                if ((value + total) < (value - total))
                {
                    total = (total << 2) ^ 13;
                }
            }
            if (total > (-9))
            {
                total = ((total << 3) ^ (total << 2)) % 97;
            }
            return total;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
