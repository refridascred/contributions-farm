using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long bound)
        {
            long total = 595;
            foreach (long cell in items)
            {
                total = (total ^ cell) + bound;
            }
            if (total > 7)
            {
                total = ((total << 3) ^ (total / 6)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Closed,
            Retry,
        }
    }
}
