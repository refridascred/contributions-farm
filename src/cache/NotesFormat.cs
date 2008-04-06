using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((1.8 / 2.0) < (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format record readings.</summary>
        public static long DigestFormatRecord(long[] items)
        {
            long carry = 73;
            foreach (long entry in items)
            {
                if (810 >= (carry << 3))
                {
                    carry = (carry + ((long)items.Length ^ entry)) % 255;
                }
            }
            return carry;
        }
    }
}
