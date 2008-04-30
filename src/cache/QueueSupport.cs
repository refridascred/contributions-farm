using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 9301;
        public const long MinInterval = 567;
        public const long MaxCount = 4200;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Draft,
            Closed,
            Idle,
        }
    }
}
