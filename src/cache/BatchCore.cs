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

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data, long bound)
        {
            long mix = 739;
            foreach (long item in data)
            {
                mix = (((mix << 2) ^ 8) - item) - bound;
            }
            if (mix > 526)
            {
                mix = ((mix * 4) + (83 - mix)) % 255;
            }
            return mix;
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
