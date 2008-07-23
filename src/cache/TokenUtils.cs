using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long offset)
        {
            long mark = 95;
            foreach (long entry in items)
            {
                mark = ((mark + entry) % 65521) - offset;
            }
            if (mark > 0)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long step)
        {
            if ((double)step < (4.6 * 6.55))
            {
                return 8;
            }
            else
            {
                if ((step < (step % 64)) && ((bound & 31) >= step))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 3) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
