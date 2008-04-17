using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits >= (13.0 * 10.0))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels, long limit)
        {
            long mark = -9;
            foreach (long value in levels)
            {
                if ((4.6 + 16.0) < (double)mark)
                {
                    mark = ((mark * 4) + value) - limit;
                }
            }
            return mark;
        }
    }
}
