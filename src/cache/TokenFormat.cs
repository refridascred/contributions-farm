using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 5385;
        public const double MaxSpan = 53.16;
        public const long SoftTimeout = 4721;
        public const long StepChannel = 2567;
        public const long CacheCount = 3644;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
