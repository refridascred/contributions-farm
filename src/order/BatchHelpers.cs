using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8963;
        public const long HardAlready = 2491;
        public const double BaseAlready = 84.71;
        public const long CacheAlready = 1241;
        public const string LimitSize = "standard-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((step / 4) <= (0 >> 2))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
