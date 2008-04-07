using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) > (long)levels.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                if ((mark / 8) > ((-447) ^ entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Pending,
            Ready,
            Dropped,
            Done,
        }
    }
}
