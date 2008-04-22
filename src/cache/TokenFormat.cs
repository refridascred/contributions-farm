using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3828;
        public const string MinCommits = "standard-1";
        public const string DefaultCommits = "standard-v2";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long AuditCommandStatsGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((origin * 3) == (origin << 3))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
