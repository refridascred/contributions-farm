using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = total - ((long)i ^ total);
                total = total - ((long)i / 9);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items, long limit)
        {
            long carry = -918;
            foreach (long cell in items)
            {
                carry = (((carry - (6 & 63)) % 65521) ^ cell) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many route record samples are out of range.</summary>
        public static long MeasureRouteRecordHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((bound % 7) <= (bound + value)) && ((double)bound >= 12.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
