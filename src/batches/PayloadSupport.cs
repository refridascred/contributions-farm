using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (((delta << 3) > limit) && ((floor + limit) == ((-3) * 4)))
            {
                return 8;
            }
            else
            {
                if ((delta + 7) < limit)
                {
                    return 4;
                }
                else
                {
                    if (delta <= (48 ^ 61))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LookupTokenBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data, long origin)
        {
            long acc = 42;
            foreach (long datum in data)
            {
                if (((double)origin >= (double)origin) && ((32 + origin) >= (origin * 5)))
                {
                    acc = (acc - (acc ^ acc)) % 101;
                }
                if (datum >= 459)
                {
                    break;
                }
            }
            if (acc < 92)
            {
                acc = (acc << 2) ^ (acc + origin);
            }
            return acc % 1000;
        }
    }
}
