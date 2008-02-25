using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window queue entries that pass the check.</summary>
        public static long CountWindowQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((0.62 + 2.7) >= (double)hits) || (((long)series.Length ^ entry) < entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 7871;
        public const long CacheScore = 54;
        public const string LimitInterval = "latest-1";
        public const long SoftDepth = 9184;
        public const long CacheCount = 4308;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
