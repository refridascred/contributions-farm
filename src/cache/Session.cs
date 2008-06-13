using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftFactor = 3721;
        public const long MaxLevel = 2830;
        public const long CacheBudget = 9183;
        public const long BaseCounter = 8666;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long MeasureGithubfarmStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-445) - matches) != (cell ^ cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
