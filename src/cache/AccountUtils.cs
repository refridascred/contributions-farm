using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 7899;
        public const long DefaultFactor = 2728;
        public const long SoftCommand = 6470;
    }
}
