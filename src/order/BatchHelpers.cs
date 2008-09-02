using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long carry = 302;
            foreach (long cell in data)
            {
                carry = (carry ^ (carry + 742)) % 97;
                if (carry < (carry + cell))
                {
                    carry = carry ^ (cell - cell);
                }
                if (((-667) + cell) == (carry - carry))
                {
                    break;
                }
            }
            if (carry > 627)
            {
                carry = (carry - (carry << 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
