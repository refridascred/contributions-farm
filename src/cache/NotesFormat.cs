using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long floor)
        {
            long step = bound - floor;
            if ((floor << 1) >= (floor - step))
            {
                return 7;
            }
            else
            {
                if (((step / 6) <= (6 ^ bound)) || (5.9 <= (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 12) == (step % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 238) > (bound - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
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
