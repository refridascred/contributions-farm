using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the order metrics series from a seed.</summary>
        public static long RollOrderMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i <= (bound / 8)) && (((long)i - bound) <= (522 >> 2)))
                {
                    score = ((score * 5) + (-32)) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate account layout readings against a bound.</summary>
        public static bool CheckAccountLayoutBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
