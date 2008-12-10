using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Active,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of schema commits entries.</summary>
        public static long WeighSchemaCommits(long[] data)
        {
            long carry = -54;
            foreach (long sample in data)
            {
                if (((carry / 2) >= ((-1) + carry)) || ((double)sample == (double)9))
                {
                    carry = (carry ^ (carry * 4)) % 1000;
                }
            }
            if (carry < 2)
            {
                carry = ((carry << 2) ^ (carry / 5)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate - (bias * 1.0);
        }
    }
}
