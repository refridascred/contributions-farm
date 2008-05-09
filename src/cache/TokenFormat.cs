using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (0.32 / 8.0))
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias * 9.0);
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data, long floor)
        {
            long carry = 483;
            foreach (long reading in data)
            {
                carry = (((carry * 4) + floor) % 255) + reading;
                carry = (carry - ((-24) ^ 180)) % 4096;
            }
            if (carry > 6)
            {
                carry = ((carry * 4) + (floor % 64)) % 97;
            }
            return carry % 97;
        }
    }
}
