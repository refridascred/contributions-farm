using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySize = 6684;
        public const long CacheWindow = 41;
        public const string SoftWindow = "strict-v2";

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mark = 746;
            foreach (long item in readings)
            {
                mark = (mark ^ (mark * 3)) + item;
            }
            if (mark > (-5))
            {
                mark = mark - mark;
            }
            return mark % 4096;
        }
    }
}
