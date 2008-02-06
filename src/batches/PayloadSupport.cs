using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1843;
        public const double HardQueue = 74.95;
        public const double BurstQueue = 95.34;
        public const long RetryQueue = 3733;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
