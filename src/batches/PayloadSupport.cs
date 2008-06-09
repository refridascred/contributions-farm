using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5592;
        public const double IdleEditor = 97.98;
        public const double MaxEditor = 20.52;
        public const double MinBudget = 1.36;
        public const long DefaultFactor = 2375;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
