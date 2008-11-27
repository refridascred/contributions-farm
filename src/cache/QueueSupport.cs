using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxSize = 7527;
        public const long IdleContributi = 4264;
        public const long StepContributi = 9931;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Synced,
            Ready,
            Pending,
            Locked,
        }
    }
}
