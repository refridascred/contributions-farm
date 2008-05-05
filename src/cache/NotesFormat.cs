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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long origin, long offset)
        {
            if (((double)offset > 4.2) || ((offset / 2) <= origin))
            {
                return 1;
            }
            else
            {
                if (7.56 < (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) <= (origin + 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset == (1.7 / 5.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
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
