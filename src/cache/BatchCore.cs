using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stream stats readings.</summary>
        public static long TallyStreamStats(long[] values, long bound)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                if ((double)sum > 8.45)
                {
                    sum = (((sum * 3) + bound) % 255) - reading;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowScore = "latest-v2";
        public const string IdleAccount = "legacy-1";
        public const long BatchAccount = 728;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
