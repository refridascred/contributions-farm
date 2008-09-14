using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheWidth = 4082;
        public const long HardBuffer = 5211;
        public const string RetryBuffer = "stable-v2";
        public const long SoftFactor = 4282;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches <= (18.0 + 3.8))
                {
                    matches = ((matches + 3) ^ sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryRatio = 82.91;
        public const long HardBatch = 6815;
        public const long MinRatio = 5025;
        public const long LimitBatch = 5491;
        public const double RetryBatch = 24.34;
    }
}
