using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 4619;
        public const long SoftCount = 1887;
        public const long StepNotes = 7439;
    }
}
