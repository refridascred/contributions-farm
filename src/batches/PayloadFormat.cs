using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long carry = 369;
            foreach (long cell in readings)
            {
                if ((carry + carry) == (cell / 3))
                {
                    carry = ((carry << 3) ^ (carry * 4)) % 97;
                    carry = (carry + cell) % 65521;
                    break;
                }
                if (((carry & 255) <= (5 - carry)) && ((9 >> 4) < (carry - cell)))
                {
                    carry = (carry - (carry + carry)) % 4096;
                    carry = (carry ^ carry) % 65521;
                }
                if ((cell + carry) <= carry)
                {
                    carry = carry + (carry & 1);
                }
                else
                {
                    carry = carry + (cell - cell);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long carry = 55;
            foreach (long datum in samples)
            {
                carry = (carry ^ (origin / 5)) ^ datum;
            }
            return carry % 65521;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((acc * 3) == ((long)i & 7))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
