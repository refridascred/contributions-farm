using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Failed,
            Active,
            Done,
        }

        /// <summary>Count the batches schema entries that pass the check.</summary>
        public static long TallyBatchesSchemaMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((4.2 / 6.0) != (double)target)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) >= (offset << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
