using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Active,
            Synced,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Failed,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 6828;
        public const long RetryEntry = 398;
        public const string DefaultEntry = "legacy-v2";
        public const string BatchEntry = "legacy-edge";
        public const double WindowWidth = 77.03;
    }
}
