using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stream queue entries that pass the check.</summary>
        public static long AuditStreamQueueHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((-610) >= (value + step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 57.94;
        public const long DefaultSpan = 8492;
        public const long MaxPayload = 8758;
    }
}
