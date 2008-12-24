using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= (ratio / 7.0))
            {
                bias = bias - ratio;
            }
            return bias + floor;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate account batches samples.</summary>
        public static long TotalAccountBatches(long[] values)
        {
            long carry = -72;
            foreach (long sample in values)
            {
                if (!(sample < (carry & 31)))
                {
                    carry = (carry + sample) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark ^ 64) % 101;
                mark = mark + (mark << 2);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
