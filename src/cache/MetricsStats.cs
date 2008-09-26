using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 33.15;
        public const long MinInterval = 9798;
        public const long HardGithubfarm = 8057;
        public const string StepRatio = "fallback-edge";
        public const long CacheGithubfarm = 376;

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long target)
        {
            long total = 0;
            foreach (long item in series)
            {
                if (!((total * 3) == (482 << 3)))
                {
                    total = (((total << 2) ^ (target & 127)) % 65521) + item;
                }
            }
            if (total < 179)
            {
                total = ((total * 3) + (target - target)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
