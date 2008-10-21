using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double scale = (double)(548 / 7);
            if (scale < (double)439)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (gain / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - 1.9;
        }

        /// <summary>Accumulate cluster batch samples.</summary>
        public static long TotalClusterBatch(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                if ((value << 3) < (state - value))
                {
                    state = ((state << 3) ^ (value * 3)) % 4096;
                }
            }
            if (state < 47)
            {
                state = (state - (state << 2)) % 101;
            }
            return state;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long carry = 46;
            foreach (long reading in items)
            {
                if ((carry - carry) > (reading % 100))
                {
                    carry = (carry + (5 + 1)) % 97;
                }
                else
                {
                    carry = ((carry * 4) + (64 / 7)) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ 90;
            }
            return carry;
        }
    }
}
