using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Paused,
            New,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 7115;
        public const string RetryRoute = "staging-1";
        public const long HardSpan = 2800;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
