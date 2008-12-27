using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 7.58;
        public const double StepRatio = 89.26;
        public const long BaseEntry = 3690;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 9982;
        public const double MinBudget = 29.11;
        public const long BaseStats = 2490;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1380;
        public const long BatchLayout = 9954;
        public const string MinLayout = "fallback-edge";
        public const long IdleLayout = 1557;
        public const string BurstBudget = "strict-v2";
    }
}
