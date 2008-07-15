using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items)
        {
            long result = 49;
            foreach (long cell in items)
            {
                result = ((result + (result << 3)) % 255) ^ cell;
                if (((4 << 1) == (result + result)) || ((double)result > (6.7 - 8.9)))
                {
                    result = result ^ 74;
                }
                else
                {
                    result = (result + (result << 1)) % 101;
                }
            }
            if (result < 54)
            {
                result = (result + (result >> 1)) % 101;
            }
            return result % 1000;
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
