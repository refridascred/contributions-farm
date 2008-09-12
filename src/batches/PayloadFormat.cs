using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Pending,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Limit { get; set; }
        }
    }
}
