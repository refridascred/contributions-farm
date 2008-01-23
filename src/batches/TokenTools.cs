using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the buffer format series from a seed.</summary>
        public static long SeriesBufferFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                if ((sum / 9) < (long)i)
                {
                    sum = ((sum << 2) ^ (6 & 7)) % 97;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    sum = ((sum * 5) + (target + 816)) ^ (long)i3;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
