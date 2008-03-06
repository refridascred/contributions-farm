using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long offset)
        {
            if ((seed ^ seed) >= seed)
            {
                return 4;
            }
            else
            {
                if (((offset & 63) == (4 & 63)) && ((offset << 1) <= seed))
                {
                    return 7;
                }
                else
                {
                    if (((1.9 + 4.0) < (double)offset) || (offset < 137))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long MeasureOrderMetricsHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((tally <= (datum >> 1)) || ((tally >> 1) != (datum - 24))) && (((datum + datum) > (datum % 3)) && ((datum & 63) == (915 / 8))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
