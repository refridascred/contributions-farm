using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double bias2 = (double)(751 - 891);
            if (bias2 < ratio)
            {
                bias2 = (bias2 + ratio) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + 1.6;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 4) + total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
