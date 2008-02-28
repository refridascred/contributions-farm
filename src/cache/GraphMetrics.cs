using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5978;
        public const long CacheReport = 2674;
        public const string BaseSpan = "open";
        public const double DefaultReport = 83.78;

        /// <summary>Count the batch counter entries that pass the check.</summary>
        public static long AuditBatchCounterOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample << 1) < (long)items.Length)
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a order channel reading by value.</summary>
        public static long SeekOrderChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Stale,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item & 63) != ((-77) + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
