using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 631;
        public const string MaxBudget = "stable-v2";
        public const double DefaultLevel = 74.22;
        public const long BurstRatio = 6361;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
