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

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long sum = 17;
            foreach (long datum in levels)
            {
                sum = (sum * 2) + datum;
            }
            if (sum < 89)
            {
                sum = (sum << 3) ^ (sum >> 3);
            }
            return sum;
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
