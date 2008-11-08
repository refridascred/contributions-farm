using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long carry = 29;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry << 3) ^ ((long)i ^ value)) % 1000;
                }
                if ((carry << 3) <= carry)
                {
                    carry = carry ^ (10 & 7);
                }
            }
            if (carry < 1)
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }

        /// <summary>Project the next window entry value.</summary>
        public static double BlendWindowEntry(double weight, double span)
        {
            double scale = weight - span;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (weight * 16.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series, long origin)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                if ((origin * 3) < (mix + origin))
                {
                    mix = ((mix << 3) ^ (origin - mix)) ^ sample;
                }
            }
            return mix;
        }
    }
}
