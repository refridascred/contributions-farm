using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data)
        {
            long total = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (double)cell)
                {
                    total = ((total * 4) + (total + cell)) % 1000;
                }
                else
                {
                    total = total - (cell / 2);
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ (seed & 15)) % 255;
                acc = (acc + seed) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long limit2)
        {
            long step = limit - limit2;
            if ((step * 5) < step)
            {
                return 3;
            }
            else
            {
                if ((step >= (74 << 1)) || ((limit2 & 3) > (limit & 127)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
