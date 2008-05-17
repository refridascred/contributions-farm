using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "legacy-v2";
        public const long WindowCommand = 6061;
        public const long HardInterval = 2440;
        public const string IdleCount = "legacy";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
