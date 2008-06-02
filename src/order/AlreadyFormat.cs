using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = (carry ^ entry) % 65521;
            }
            if (carry > 186)
            {
                carry = carry - (carry - limit);
            }
            return carry % 4096;
        }

        /// <summary>Roll a layout metric counter forward.</summary>
        public static long IterateLayoutMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 2) ^ (long)i) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double weight, double bias)
        {
            double gain = weight;
            if (gain > (double)(-5))
            {
                gain = gain + bias;
            }
            return gain - bias;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
