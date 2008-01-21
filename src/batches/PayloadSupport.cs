using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long GradeWindowCache(long origin, long offset)
        {
            long cur = origin - offset;
            if ((double)origin > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset ^ origin) < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset - cur))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
