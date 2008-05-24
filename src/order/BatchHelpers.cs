using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                long hits = offset;
                mark = mark + (hits % 5);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double rate = (6.3 * 4.9) - span;
            if (rate <= (double)152)
            {
                rate = rate - (double)847;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
