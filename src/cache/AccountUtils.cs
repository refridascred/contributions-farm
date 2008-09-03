using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 69.46;
        public const long CacheCount = 283;
        public const string StepFilter = "fallback-1";
        public const string MinFilter = "local-edge";

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
