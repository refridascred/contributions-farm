using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count window entry pairs that satisfy a relation.</summary>
        public static long CompareWindowEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (slot >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((floor > ((-92) ^ slot)) || ((slot + slot) > slot))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series)
        {
            long mark = 65;
            foreach (long cell in series)
            {
                mark = (mark + mark) % 255;
                if ((double)(-144) == (double)cell)
                {
                    mark = ((mark * 5) + (cell / 5)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 557;
        public const double WindowCommand = 39.31;
        public const long IdleCommand = 6249;
        public const long MinSize = 2723;
    }
}
