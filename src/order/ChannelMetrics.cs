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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] series, long step)
        {
            long mark = 430;
            foreach (long reading in series)
            {
                if (step >= (step << 2))
                {
                    mark = ((mark - (step / 7)) % 97) - reading;
                }
                else
                {
                    mark = (mark << 3) ^ (step % 60);
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 1728;
        public const long DefaultDepth = 1157;
        public const string DefaultTimeout = "open-1";
        public const long LimitCount = 7407;
    }
}
