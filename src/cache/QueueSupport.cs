using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Locked,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7969;
        public const long BurstEntry = 9642;
        public const double MaxBudget = 81.27;

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 56.69;
        public const long LimitRoute = 9406;
        public const long StepRoute = 2926;
        public const long MinDepth = 5231;
    }
}
