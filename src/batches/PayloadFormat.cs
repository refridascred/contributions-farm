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

        /// <summary>Derive the next channel cache value from a seed.</summary>
        public static long RollChannelCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                long hits = bound;
                double bias = (7.5 * 4.31) - (0.7 - 2.6);
                if (((double)hits <= (bias - bias)) || ((bias * 13.0) <= bias))
                {
                    bias = bias - (double)mix;
                    bias = bias + bias;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
