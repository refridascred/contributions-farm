using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryDepth = 53.45;
        public const double BatchBuffer = 32.96;
        public const long BurstCount = 9749;
        public const double HardCount = 51.87;
        public const long DefaultFactor = 4539;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
