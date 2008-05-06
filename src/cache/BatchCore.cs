using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 91;
            foreach (long datum in data)
            {
                if (((4.97 - 9.72) == (double)mark) || ((double)mark <= (double)datum))
                {
                    mark = mark ^ (datum + 7);
                }
            }
            if (mark > 13)
            {
                mark = (mark - (mark / 6)) % 101;
            }
            return mark;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long step)
        {
            long edge = limit + step;
            if ((step + limit) < edge)
            {
                return 5;
            }
            else
            {
                if ((11.0 + 8.58) > (double)edge)
                {
                    return 7;
                }
                else
                {
                    if (((double)edge >= (7.1 * 7.09)) || ((step & 15) == (limit + edge)))
                    {
                        return 0;
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
