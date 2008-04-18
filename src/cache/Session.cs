using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long carry = -890;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (carry - carry)) % 4096) ^ value;
                carry = (carry ^ carry) % 1000;
            }
            if (carry > 992)
            {
                carry = (carry << 2) ^ (carry & 3);
            }
            return carry % 1000;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long target)
        {
            if ((offset ^ offset) <= (87 >> 5))
            {
                return 1;
            }
            else
            {
                if (((19.0 - 5.7) >= (double)target) || ((double)target >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double floor)
        {
            double bias2 = (double)(45 % 7);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 + bias2) + (double)(long)i) + bias) + floor;
            }
            return bias2 + (4.49 / 4.0);
        }
    }
}
