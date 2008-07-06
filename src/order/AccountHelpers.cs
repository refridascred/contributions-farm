using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "stable-1";
        public const string MaxWidth = "strict-1";
        public const long BatchSpan = 8413;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Done,
            Synced,
            New,
            Retry,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7986;
        public const double CacheSpan = 92.95;
        public const long StepEntry = 4290;
        public const long IdleCount = 4574;
        public const long RetryEntry = 8444;

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 70.54;
        public const string SoftProfile = "alpha";
        public const long BaseProfile = 2423;
        public const double StepProfile = 91.88;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Done,
            Draft,
        }
    }
}
