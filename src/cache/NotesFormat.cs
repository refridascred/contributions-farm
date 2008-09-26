using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseDepth = 1760;
        public const string MinInterval = "stable-edge";
        public const long BurstBudget = 9035;
        public const long DefaultSpan = 5601;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
