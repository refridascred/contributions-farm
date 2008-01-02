using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitSize = "fallback-v2";
        public const double MinOrder = 84.47;
        public const long SoftRatio = 9223;

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultWidth = "primary-edge";
        public const double BaseLevel = 43.22;
        public const string BaseBatches = "fallback";
        public const long BatchBatches = 1467;
        public const long StepBatches = 7985;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Done,
            Paused,
            Dropped,
        }
    }
}
