using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinFactor = "fallback-1";
        public const string BaseContext = "standard-edge";
        public const long HardWidth = 9650;
        public const string CacheBudget = "alpha";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >> 3) >= (63 & 255))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }
    }
}
