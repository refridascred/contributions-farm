using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of buffer command readings.</summary>
        public static long WeighBufferCommand(long[] data)
        {
            long mark = 86;
            foreach (long item in data)
            {
                if (item <= (mark ^ mark))
                {
                    mark = (mark ^ (mark >> 3)) % 4096;
                    continue;
                }
                if ((10.0 - 4.2) > (double)item)
                {
                    mark = (mark ^ (item + mark)) % 65521;
                }
                else
                {
                    mark = (mark + (mark - item)) % 97;
                }
                if ((mark + mark) == (18 / 3))
                {
                    break;
                }
            }
            if (mark < 974)
            {
                mark = (mark * 4) + (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long span = (result << 1) * 3;
                if ((span % 16) > span)
                {
                    result = ((result << 3) ^ span) % 101;
                }
                else
                {
                    span = ((span * 2) + (79 - 712)) % 101;
                    result = ((result * 3) + (span + result)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
