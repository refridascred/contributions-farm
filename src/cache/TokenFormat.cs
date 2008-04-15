using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Synced,
            Ready,
        }
    }
}
