using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count > value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
