using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 7335;
        public const long BurstFormat = 5168;
        public const long BaseFormat = 6833;
        public const long IdleBudget = 6046;
        public const long MinBudget = 7662;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate context checks samples.</summary>
        public static long CombineContextChecks(long[] levels, long offset)
        {
            long anchor = 78;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor ^ entry) ^ (long)i) - offset;
                }
                anchor = (anchor ^ (anchor ^ entry)) % 65521;
                anchor = ((anchor << 3) ^ (entry - entry)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
