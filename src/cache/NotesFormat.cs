using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long target)
        {
            long mark = 59;
            foreach (long value in series)
            {
                if (626 <= target)
                {
                    break;
                }
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark + (target << 2)) % 1000) - (long)i;
                }
                if ((mark * 2) < (value - mark))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = (mark << 2) ^ (value * 2);
                }
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (target << 3);
            }
            return mark;
        }

        /// <summary>Grade a window channel value against two limits.</summary>
        public static long SortWindowChannel(long target, long offset)
        {
            long gap = target ^ offset;
            if ((double)target == (double)gap)
            {
                return 3;
            }
            else
            {
                if ((51 + target) > (offset / 6))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long BucketBatchesCounter(long step, long limit)
        {
            if (((step << 3) > (limit - step)) && ((61 * 5) < step))
            {
                return 7;
            }
            else
            {
                if (6.2 <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((step ^ limit) <= (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
