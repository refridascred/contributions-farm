using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchWidth = "primary-edge";
        public const long MinEntry = 7137;
        public const string HardEntry = "standard-v2";
        public const long RetryDepth = 6445;
    }
}
