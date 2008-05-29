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

        /// <summary>Roll a farm layout counter forward.</summary>
        public static long SeriesFarmLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - 36) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 1728;
        public const long DefaultDepth = 1157;
        public const string DefaultTimeout = "open-1";
        public const long LimitCount = 7407;
    }
}
