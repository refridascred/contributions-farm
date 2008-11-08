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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
