using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 5731;
        public const long BatchPayload = 3234;
        public const long IdlePayload = 9551;
        public const long SoftRatio = 7192;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7971;
        public const double SoftCommand = 17.11;
        public const string HardCount = "legacy-v2";
    }
}
