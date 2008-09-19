using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 36.34;
        public const long IdleProfile = 4970;
        public const double MinBudget = 5.33;
        public const long WindowProfile = 2138;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardSpan = "alpha-1";
        public const long StepContributi = 6966;
        public const double BaseLevel = 73.32;
        public const double IdleScore = 77.76;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
