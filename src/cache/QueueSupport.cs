using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many channel stats samples are out of range.</summary>
        public static long TallyChannelStatsOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen % 12) >= seen)
                {
                    seen = ((seen + 2) + item) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + hits) <= (hits >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
