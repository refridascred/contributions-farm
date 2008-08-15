using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data, long origin)
        {
            long acc = 9;
            foreach (long value in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc + acc) % 65521) + (long)i) + value;
                }
                acc = (acc << 2) ^ (origin - acc);
            }
            return acc % 1000;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long seed)
        {
            long mark = 55;
            foreach (long value in series)
            {
                if ((double)mark > (0.9 / 4.0))
                {
                    mark = mark + (seed << 1);
                    mark = mark + value;
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark - value) % 4096) ^ (long)i;
                }
                if ((seed * 4) > (seed / 6))
                {
                    mark = ((mark * 4) + seed) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
