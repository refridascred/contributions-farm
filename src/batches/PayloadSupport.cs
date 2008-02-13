using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Failed,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstLevel = 20.48;
        public const long DefaultFactor = 8299;
        public const double MaxSpan = 53.52;
        public const long LimitBatches = 9749;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Paused,
            Pending,
            Synced,
        }
    }
}
