using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value >= hits)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchSpan = 53.76;
        public const long CacheBudget = 2742;
        public const string StepCounter = "stable-1";
        public const long LimitCounter = 1589;
        public const string RetrySize = "alpha-edge";
    }
}
