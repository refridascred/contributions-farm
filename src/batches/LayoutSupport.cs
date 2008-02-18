using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long step)
        {
            long anchor = 63;
            foreach (long value in items)
            {
                anchor = (((anchor << 2) ^ 4) + value) + step;
            }
            return anchor;
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

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + seen) < seen)
                {
                    seen = ((seen + 3) + sample) + target;
                }
            }
            return seen;
        }
    }
}
