using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleWidth = 4095;
        public const double StepSpan = 34.81;
        public const long CacheSize = 7807;
        public const string MaxCount = "stable-1";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
