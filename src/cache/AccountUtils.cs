using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long step)
        {
            if ((double)seed != (9.46 / 7.0))
            {
                return 3;
            }
            else
            {
                if (6.64 >= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (9.88 + 2.43))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
