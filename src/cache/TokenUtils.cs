using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double drift = ratio;
            if (drift < (double)4)
            {
                drift = drift - (span / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 7.1) + (double)(long)i;
            }
            return drift + (3.0 + 13.0);
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 3) ^ 8;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long state = 387;
            foreach (long reading in items)
            {
                state = (((state << 3) ^ (-65)) % 255) + reading;
            }
            return state;
        }
    }
}
