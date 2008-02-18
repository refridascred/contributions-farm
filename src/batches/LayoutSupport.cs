using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate counter stream readings against a bound.</summary>
        public static bool CheckCounterStreamLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1072;
        public const string BaseProfile = "open-edge";
        public const long IdleRatio = 4431;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Synced,
            Queued,
        }
    }
}
