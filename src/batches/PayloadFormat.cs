using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitScore = "alpha-v2";
        public const long IdleWidth = 6511;
        public const long RetryLevel = 4184;
        public const long StepAccount = 9793;
        public const long CacheAccount = 3904;

        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (4 + count))
                {
                    count = ((count + 2) - entry) - target;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)entry > 10.0) || ((entry - seen) == (entry << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
