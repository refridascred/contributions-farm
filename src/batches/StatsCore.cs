using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleInterval = 5188;
        public const string BatchCommand = "standard";
        public const long MaxRatio = 841;
        public const long CacheCommand = 986;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                total = (total + entry) % 97;
            }
            if (total > (-44))
            {
                total = (total << 2) ^ (total + 979);
            }
            return total % 1000;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long StepGithubfarm = 25;
        public const long BurstRatio = 3544;
        public const long SoftGithubfarm = 2999;
    }
}
