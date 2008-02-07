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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSpan = 2419;
        public const long LimitMetric = 4306;
        public const long MaxCount = 3781;
        public const long BaseMetric = 3790;
    }
}
