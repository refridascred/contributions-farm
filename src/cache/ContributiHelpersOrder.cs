using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRatio = 732;
        public const string BaseScore = "local";
        public const double DefaultCount = 58.86;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Retry,
            Draft,
            Locked,
        }
    }
}
