using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate cache queue samples.</summary>
        public static long ScoreCacheQueue(long[] data, long limit)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if ((double)datum < 0.39)
                {
                    carry = ((carry * 2) + (limit + 19)) % 97;
                }
                else
                {
                    carry = carry + (limit & 15);
                }
                if (!((limit % 24) <= (carry % 10)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total / 9) < (703 + total))
                {
                    total = total ^ limit;
                    total = (total + (total + (long)i)) % 4096;
                }
                if (9 > (limit % 16))
                {
                    total = ((total * 3) + (total + total)) % 255;
                    total = ((total << 3) ^ (total + limit)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a token support sample.</summary>
        public static long LocateTokenSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
