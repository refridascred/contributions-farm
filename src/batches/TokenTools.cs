using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Done,
            Ready,
            Active,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultScore = 4488;
        public const long WindowCount = 8688;
        public const long BaseInterval = 1462;
    }
}
