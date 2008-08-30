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

        /// <summary>Compare every pair of account notes readings.</summary>
        public static long PairAccountNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
