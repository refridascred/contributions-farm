using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Done,
            Failed,
            Paused,
            New,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)hits > (5.8 - 4.0)))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the order record entries that pass the check.</summary>
        public static long AuditOrderRecordHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count % 24) != (count + count)))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
