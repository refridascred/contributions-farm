using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 95.22;
        public const long BurstCache = 5324;
        public const long HardCache = 7056;
        public const long IdleCache = 1484;
        public const long MaxWidth = 3606;

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowBudget = "stable-edge";
        public const double LimitSchema = 11.73;
        public const long SoftTimeout = 6677;
        public const string IdleSpan = "strict-1";

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
