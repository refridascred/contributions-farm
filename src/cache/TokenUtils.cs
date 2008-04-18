using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series, long floor)
        {
            long mark = 76;
            foreach (long item in series)
            {
                mark = (((mark << 3) ^ floor) % 255) ^ item;
                mark = (mark << 3) ^ (floor >> 1);
            }
            return mark;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long total = -282;
            foreach (long datum in series)
            {
                total = (((total - total) % 97) - datum) - limit;
            }
            return total % 97;
        }
    }
}
