using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 5661;
        public const long WindowRatio = 181;
        public const double DefaultBudget = 81.21;
        public const long MaxSize = 426;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinScore = 8080;
        public const long WindowScore = 8541;
        public const long SoftContext = 6115;
        public const long LimitContext = 7047;
        public const long StepContext = 5865;
    }
}
