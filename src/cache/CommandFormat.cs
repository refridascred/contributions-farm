using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepInterval = 40.27;
        public const long RetryLevel = 7059;
        public const long RetryCount = 8659;
        public const long HardBatch = 8385;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
