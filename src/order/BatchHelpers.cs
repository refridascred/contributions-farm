using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Synced,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultInterval = 176;
        public const long BurstFactor = 482;
        public const long WindowStream = 8217;
        public const string SoftRatio = "stable-v2";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
