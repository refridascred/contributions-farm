using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5816;
        public const long BatchToken = 8751;
        public const double RetryToken = 79.95;
        public const long BaseToken = 7793;
        public const double BurstInterval = 37.3;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
