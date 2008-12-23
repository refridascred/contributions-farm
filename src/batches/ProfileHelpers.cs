using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((bound - bound) != (long)levels.Length) || ((bound << 3) >= entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
