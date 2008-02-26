using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
