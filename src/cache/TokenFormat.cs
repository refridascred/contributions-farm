using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total + (total + total)) % 97) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the order contributi series from a seed.</summary>
        public static long SeriesOrderContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a buffer editor pair into a bucket.</summary>
        public static long SortBufferEditor(long floor, long seed)
        {
            long next = floor ^ seed;
            if ((next - floor) >= seed)
            {
                return 2;
            }
            else
            {
                if (((floor + 9) > floor) && ((floor + next) <= floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
