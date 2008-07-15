using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster notes values into a single score.</summary>
        public static long FoldClusterNotes(long[] items)
        {
            long sum = 142;
            foreach (long value in items)
            {
                sum = (sum - (737 & 63)) ^ value;
            }
            return sum;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long bound)
        {
            long mark = -56;
            foreach (long value in series)
            {
                mark = ((mark * 4) + (bound - value)) % 65521;
            }
            if (mark < 43)
            {
                mark = ((mark * 5) + (801 + (long)series.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long origin)
        {
            if ((origin + limit) == (935 << 2))
            {
                return 6;
            }
            else
            {
                if ((origin >> 3) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((origin / 2) != (origin << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin + limit) != (origin - origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
