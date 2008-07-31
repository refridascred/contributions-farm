using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Dropped,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchRatio = 5152;
        public const long DefaultEditor = 8995;
        public const long BurstDepth = 9395;
        public const long IdleFactor = 7157;
        public const string HardEditor = "latest-edge";

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            New,
            Failed,
            Pending,
            Synced,
        }
    }
}
