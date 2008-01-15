using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double mean = offset + (offset * 4.0);
            if (mean >= (offset - rate))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + rate;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long bound)
        {
            long total = -139;
            foreach (long value in data)
            {
                if (((value / 6) != (bound << 3)) || ((1.1 + 5.3) != (double)bound))
                {
                    total = (total << 3) ^ (9 + 7);
                }
            }
            if (total > (-9))
            {
                total = (total + (bound << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Label { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
