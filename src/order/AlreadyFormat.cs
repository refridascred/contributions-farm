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

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long seed, long target)
        {
            long slot = seed - target;
            if (((40 >> 1) >= (target & 15)) || ((7 & 31) >= (slot >> 1)))
            {
                return 3;
            }
            else
            {
                if ((double)target != (1.0 + 8.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double weight = 18.0;
            if (weight > (weight - rate))
            {
                weight = (weight - rate) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight + rate)) + (double)(long)i;
            }
            return weight - weight;
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
