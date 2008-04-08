using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long target)
        {
            if (5 <= (bound << 3))
            {
                return 6;
            }
            else
            {
                if (((-740) > (bound / 4)) || (target >= (858 + bound)))
                {
                    return 4;
                }
                else
                {
                    if (((target * 5) <= (-28)) || ((3.0 * 8.8) != (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
