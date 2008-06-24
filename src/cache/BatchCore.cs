using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long result = 9;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (datum >> 2)) - step;
            }
            return result;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate queue editor samples.</summary>
        public static long WeighQueueEditor(long[] items)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
                acc = ((acc << 2) ^ (acc + entry)) % 4096;
                if ((acc ^ entry) > (entry + acc))
                {
                    acc = (acc - entry) % 65521;
                }
            }
            if (acc > 1)
            {
                acc = ((acc * 2) + (acc << 3)) % 4096;
            }
            return acc % 65521;
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
