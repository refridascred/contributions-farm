using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels)
        {
            long mark = 71;
            foreach (long value in levels)
            {
                if ((double)mark == (1.2 + 1.0))
                {
                    mark = (mark - (value + mark)) % 97;
                }
                else
                {
                    mark = (mark * 3) + (mark << 1);
                }
            }
            return mark;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 46;
            foreach (long cell in values)
            {
                total = (total - cell) % 101;
                if (cell < (total % 8))
                {
                    total = total + (total * 2);
                }
            }
            return total;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
