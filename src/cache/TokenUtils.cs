using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double rate = (double)(2 - 456);
            if (rate < gain)
            {
                rate = rate - (bias / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)31) - (double)(long)i;
            }
            return rate - (double)84;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
