using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 57.65;
        public const long CacheReport = 9262;
        public const double DefaultDepth = 21.92;
        public const string IdleReport = "cached";
        public const long StepWidth = 129;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (16.0 / 8.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 48.92;
        public const string BaseWidth = "primary-1";
        public const double StepProfile = 12.06;
        public const long MaxSpan = 8750;
        public const long StepLevel = 8529;
    }
}
