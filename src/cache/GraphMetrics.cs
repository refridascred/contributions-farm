using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "alpha";
        public const long BaseStream = 5045;
        public const long RetryDepth = 5452;
        public const string IdleDepth = "latest";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long DigestChannelBatch(long[] items)
        {
            long total = 774;
            foreach (long item in items)
            {
                total = (total - (total + item)) % 101;
            }
            if (total > 5)
            {
                total = ((total * 5) + total) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Paused,
            Dropped,
            Synced,
            Failed,
        }
    }
}
