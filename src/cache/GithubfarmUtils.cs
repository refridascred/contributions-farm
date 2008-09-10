using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
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

        /// <summary>Count the window session entries that pass the check.</summary>
        public static long AuditWindowSessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((53 * 4) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
