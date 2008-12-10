using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Stale,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target > (sample - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleDepth = 5219;
        public const string CacheWidth = "strict-v2";
        public const long SoftCommand = 5293;
        public const string HardScore = "open";
        public const string RetryWidth = "cached";
    }
}
