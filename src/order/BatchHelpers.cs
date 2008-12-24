using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long sum = 78;
            foreach (long entry in data)
            {
                if ((entry << 1) != (sum << 2))
                {
                    sum = (sum ^ (entry * 4)) % 255;
                }
            }
            if (sum > 767)
            {
                sum = sum + (9 + sum);
            }
            return sum % 1000;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double bias2 = (double)(47 * 5);
            if (bias2 >= 6.15)
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (gain / 4.0)) + (double)(long)i;
            }
            return bias2 - (bias + gain);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = -45;
            foreach (long entry in readings)
            {
                if (((549 + entry) > (entry & 31)) && ((double)entry == (4.0 + 19.0)))
                {
                    total = ((total * 5) + (entry + total)) % 1000;
                }
                else
                {
                    total = (total + (total ^ entry)) % 4096;
                }
            }
            if (total > 766)
            {
                total = (total ^ total) % 1000;
            }
            return total % 65521;
        }
    }
}
