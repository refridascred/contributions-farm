using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 88.52;
        public const long BaseBatches = 8780;
        public const long IdleLevel = 1563;
        public const long BatchBatches = 9020;
        public const long BatchTimeout = 628;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Pending,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (tally < 921)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
