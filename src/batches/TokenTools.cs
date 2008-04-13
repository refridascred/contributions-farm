using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 9675;
        public const double IdleSize = 45.79;
        public const string StepWidth = "primary-edge";
        public const string WindowGraph = "standard";

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
