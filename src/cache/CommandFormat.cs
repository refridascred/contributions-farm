using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 5436;
        public const double MaxFilter = 88.68;
        public const string HardSpan = "alpha";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Synced,
            Failed,
            New,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 14.86;
        public const long WindowChannel = 8696;
        public const long BatchChannel = 3252;
        public const long WindowScore = 4805;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
