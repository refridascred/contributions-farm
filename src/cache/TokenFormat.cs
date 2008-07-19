using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
