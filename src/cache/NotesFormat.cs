using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstCount = 1392;
        public const double StepCount = 47.39;
        public const long WindowScore = 6603;
        public const double IdleTimeout = 81.7;
        public const long IdleProfile = 3556;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
