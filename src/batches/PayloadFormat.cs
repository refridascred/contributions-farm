using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of token counter readings.</summary>
        public static long FoldTokenCounter(long[] samples, long floor)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if ((double)carry > (double)value)
                {
                    carry = (carry << 2) ^ (floor * 4);
                }
                else
                {
                    carry = carry ^ (value << 1);
                }
            }
            return carry;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long anchor = 988;
            foreach (long datum in values)
            {
                if ((origin << 2) <= (1 & 63))
                {
                    anchor = (((anchor << 3) ^ (anchor - 52)) % 4096) + datum;
                }
            }
            return anchor;
        }
    }
}
