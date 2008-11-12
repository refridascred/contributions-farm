using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Synced,
        }
    }
}
