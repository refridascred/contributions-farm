using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheDepth = 93.98;
        public const long LimitCount = 669;
        public const long SoftStats = 6257;
        public const long BaseStats = 6988;
        public const double IdleSize = 29.96;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
