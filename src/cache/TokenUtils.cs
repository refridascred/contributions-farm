using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((454 * 5) == (target & 3)))
                {
                    total = total - target;
                    continue;
                }
                total = total - (target / 3);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (9.2 <= (double)seen)
                {
                    seen = ((seen + 3) + reading) + step;
                }
            }
            return seen;
        }
    }
}
