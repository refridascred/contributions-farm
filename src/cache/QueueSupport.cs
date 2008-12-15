using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Paused,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinSpan = 30.77;
        public const double WindowFilter = 71.8;
        public const string StepFilter = "staging-v2";
        public const long WindowSize = 1672;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Failed,
            Idle,
            Locked,
        }
    }
}
