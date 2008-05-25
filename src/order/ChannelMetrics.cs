using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= 8.8)
                {
                    hits = ((hits + 3) ^ entry) + bound;
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long SeriesCounterChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result + (target / 6)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
