using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long TallyFilterSchema(long[] data)
        {
            long mark = 20;
            foreach (long cell in data)
            {
                mark = ((mark << 2) ^ cell) % 1000;
                if (!((9 - 2) > cell))
                {
                    mark = (mark - (mark - cell)) % 65521;
                }
                if ((mark & 63) >= (cell % 16))
                {
                    break;
                }
            }
            if (mark < 78)
            {
                mark = (mark - (mark % 10)) % 4096;
            }
            return mark;
        }

        /// <summary>Grade a stats batch value against two limits.</summary>
        public static long BucketStatsBatch(long step, long limit)
        {
            if ((step - 761) == (6 - step))
            {
                return 3;
            }
            else
            {
                if (!((step * 4) < (limit % 97)))
                {
                    return 6;
                }
                else
                {
                    if (((-231) + limit) > (limit - 85))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > ((-8) - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long bound)
        {
            if (1.9 < (double)target)
            {
                return 3;
            }
            else
            {
                if ((target - target) <= bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound * 2) >= (target * 2)) && ((bound + target) <= 859))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
