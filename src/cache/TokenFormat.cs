using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseRatio = 86.88;
        public const double HardFarm = 17.04;
        public const long MinFarm = 6040;
        public const double BurstFarm = 45.44;
        public const string CacheFactor = "open-1";

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Synced,
            Paused,
        }
    }
}
