using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchDepth = "strict-1";
        public const long MinStream = 9354;
        public const long WindowSize = 6468;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9496;
        public const long BatchInterval = 9764;
        public const string StepInterval = "open-v2";
        public const double DefaultWindow = 96.08;
    }
}
