using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long target)
        {
            long diff = limit ^ target;
            if ((0 + diff) < (target + limit))
            {
                return 0;
            }
            else
            {
                if ((target - target) > ((-29) % 24))
                {
                    return 3;
                }
                else
                {
                    if (diff <= limit)
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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long bound)
        {
            if (!((double)bound >= (19.0 / 3.0)))
            {
                return 1;
            }
            else
            {
                if (step > (step << 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
