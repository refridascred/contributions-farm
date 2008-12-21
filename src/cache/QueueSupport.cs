using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long target)
        {
            long bound = limit - target;
            if ((double)bound == (7.2 / 5.0))
            {
                return 0;
            }
            else
            {
                if (1.0 > (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the counter token series from a seed.</summary>
        public static long RollCounterToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
