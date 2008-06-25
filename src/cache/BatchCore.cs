using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Stale,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Locked,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of record schema readings.</summary>
        public static long FoldRecordSchema(long[] items, long step)
        {
            long carry = 129;
            foreach (long cell in items)
            {
                carry = (((carry - (123 + 549)) % 97) + cell) - step;
            }
            return carry;
        }
    }
}
