using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double bias2)
        {
            double rate = 1.0;
            if (rate >= (bias / 8.0))
            {
                rate = rate + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + 3.9) - (double)(long)i;
            }
            return rate + (double)114;
        }
    }
}
