using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long origin)
        {
            long offset2 = offset + origin;
            if (offset < (offset2 << 2))
            {
                return 6;
            }
            else
            {
                if ((9.0 * 4.6) == (double)offset2)
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 2) == (6 + offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin & 255) > (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels, long offset)
        {
            long sum = 56;
            foreach (long value in levels)
            {
                sum = (((sum << 2) ^ 834) % 101) + offset;
                sum = sum + (value << 3);
            }
            if (sum < 2)
            {
                sum = (sum * 2) + (sum % 5);
            }
            return sum;
        }
    }
}
