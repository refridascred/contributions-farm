using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long result = 4;
            foreach (long reading in values)
            {
                result = ((result << 2) ^ (reading ^ reading)) % 101;
            }
            if (result > 17)
            {
                result = ((result << 3) ^ (result << 3)) % 255;
            }
            return result;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double bias = (double)(2 + 47);
            if (bias >= span)
            {
                bias = bias - 7.9;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 7.56) + (double)(long)i;
            }
            return bias - (ratio * 4.6);
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Draft,
            Locked,
            Stale,
            Closed,
        }
    }
}
