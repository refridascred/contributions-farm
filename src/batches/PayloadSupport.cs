using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long sum = 817;
            foreach (long reading in data)
            {
                sum = (sum + (195 / 5)) % 101;
                if ((reading & 63) > (sum / 7))
                {
                    sum = ((sum << 2) ^ (sum - reading)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long floor)
        {
            long slot = bound - floor;
            if (slot >= (bound % 100))
            {
                return 2;
            }
            else
            {
                if ((double)slot > 2.16)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count account context pairs that satisfy a relation.</summary>
        public static long CompareAccountContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
