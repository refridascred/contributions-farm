using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
