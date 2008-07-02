using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowRatio = 9647;
        public const double SoftChecks = 72.15;
        public const string DefaultCount = "stable-1";
        public const long RetryChecks = 697;
        public const long StepChecks = 9657;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
