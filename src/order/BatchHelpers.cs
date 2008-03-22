using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Active,
            New,
            Ready,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 1043;
        public const long LimitAccount = 412;
        public const long BaseInterval = 5300;
        public const string WindowAccount = "local-1";
    }
}
