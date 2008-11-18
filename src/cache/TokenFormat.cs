using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items, long target)
        {
            long state = 9;
            foreach (long sample in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (((state << 2) ^ (state ^ 338)) + (long)i) + target;
                }
                if ((long)items.Length <= sample)
                {
                    state = state - (sample & 3);
                }
                else
                {
                    state = (state + (sample + sample)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry % 97)) % 4096;
            }
            if (carry < 746)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 + scale) + span;
        }
    }
}
