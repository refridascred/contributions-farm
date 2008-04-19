using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchLevel = 3598;
        public const double MinTools = 16.86;
        public const long RetryTools = 6710;

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
