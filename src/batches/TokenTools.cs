using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseFactor = 40.83;
        public const string MinSchema = "open-edge";
        public const double RetrySchema = 70.96;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Failed,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
