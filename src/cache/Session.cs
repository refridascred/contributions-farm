using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 38.87;
        public const long RetryRatio = 347;
        public const long BatchCache = 2691;
        public const long WindowCache = 1520;
        public const long SoftCache = 2689;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
