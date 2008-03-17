using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = sum - value;
            }
            return sum % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double bias)
        {
            double drift = (double)4 / 2.0;
            if (drift < (double)6)
            {
                drift = (drift + (scale * 8.0)) + bias;
            }
            else
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 9.0)) - (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
