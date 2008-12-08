using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepFactor = "standard-edge";
        public const long RetryChannel = 7048;
        public const string BaseChannel = "open-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 8.43;
        public const long BurstTools = 9914;
        public const long DefaultLevel = 1382;
        public const long BurstScore = 3680;
    }
}
