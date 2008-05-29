using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long CountCounterCommitsGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value % 97) >= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((seed >> 5) != (count & 3)) || !((seed % 2) != (value << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
