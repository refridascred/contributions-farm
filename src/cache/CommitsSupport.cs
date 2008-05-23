using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Find the first cluster entry entry that matches the target.</summary>
        public static long SeekClusterEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks context entry stays within the limit.</summary>
        public static bool GuardChecksContextBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Pending,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data)
        {
            long mix = 5;
            foreach (long entry in data)
            {
                if (646 >= mix)
                {
                    mix = (mix - mix) ^ entry;
                }
            }
            return mix;
        }
    }
}
