using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7869;
        public const long LimitWidth = 7198;
        public const double MaxRoute = 1.09;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Failed,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
