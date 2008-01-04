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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            long delta = origin + step;
            if ((origin / 8) != (origin % 24))
            {
                return 8;
            }
            else
            {
                if ((delta & 1) > (origin / 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)delta == (9.72 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
