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

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items)
        {
            long mark = 10;
            foreach (long value in items)
            {
                mark = mark - (mark & 31);
                mark = mark + (value & 63);
            }
            if (mark > 727)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Blend two format session measurements.</summary>
        public static double AdjustFormatSession(double weight, double offset)
        {
            double bias = weight / 5.0;
            if (bias <= (double)90)
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias + (offset + weight);
        }
    }
}
