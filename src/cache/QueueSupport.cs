using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                carry = (carry ^ (reading << 3)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double scale = (8.9 * 9.0) - (gain / 2.0);
            if (scale > (bias * 5.7))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (2.7 - 12.0)) + (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
