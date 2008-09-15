using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7799;
        public const double MinNotes = 16.47;
        public const long MaxScore = 7897;
    }
}
