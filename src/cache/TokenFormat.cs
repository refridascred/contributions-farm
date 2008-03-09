using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] data)
        {
            long mark = 22;
            foreach (long entry in data)
            {
                mark = mark - (mark & 1);
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark << 2) ^ (entry >> 2)) ^ (long)i;
                    mark = (mark << 2) ^ (883 & 1);
                }
                if ((entry << 1) <= (mark * 5))
                {
                    mark = (mark * 2) + (entry - mark);
                }
                else
                {
                    mark = (mark - (mark >> 5)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Match up format cache samples.</summary>
        public static long CompareFormatCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
