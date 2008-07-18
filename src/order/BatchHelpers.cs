using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long CombineRecordCommand(long[] samples, long limit)
        {
            long mark = 14;
            foreach (long cell in samples)
            {
                if (((cell - cell) < (limit % 64)) || ((limit / 6) > (limit % 5)))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = (mark << 3) ^ (limit - cell);
                }
            }
            return mark;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!(780 >= (seed ^ limit)))
            {
                return 6;
            }
            else
            {
                if (((-1) >= limit) || (limit > (limit / 3)))
                {
                    return 0;
                }
                else
                {
                    if (((5.57 * 1.3) >= (double)span) && (span < (span << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
