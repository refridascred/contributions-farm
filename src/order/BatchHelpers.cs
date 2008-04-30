using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3683;
        public const long DefaultStream = 2007;
        public const long BurstLevel = 6873;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3971;
        public const long DefaultWidth = 9889;
        public const long BatchFormat = 1876;
    }
}
