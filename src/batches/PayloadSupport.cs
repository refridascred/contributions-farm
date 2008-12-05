using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleRatio = 8151;
        public const long WindowProfile = 7570;
        public const string DefaultProfile = "latest-edge";

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 3642;
        public const long BatchCount = 8758;
        public const string BurstInterval = "staging-edge";
    }
}
