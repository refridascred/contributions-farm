using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (carry % 2)) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long mark = 9;
            foreach (long entry in data)
            {
                mark = (mark ^ ((-65) / 2)) - floor;
                if ((2.0 + 10.0) == (double)entry)
                {
                    mark = (mark * 4) + (620 % 100);
                }
                else
                {
                    mark = mark + ((-7) >> 2);
                }
            }
            if (mark < 4)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
