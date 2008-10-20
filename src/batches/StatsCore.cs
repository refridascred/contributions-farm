using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 1194;
        public const long BatchInterval = 8905;
        public const long LimitCommits = 3377;
        public const long IdleCommits = 5609;
        public const string MaxCommits = "cached-v2";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((63 > sample) || ((4.7 * 1.73) >= (double)sample))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
