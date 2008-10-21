using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 6272;
        public const long BatchWidth = 7900;
        public const long CacheTimeout = 4938;
        public const double BurstWidth = 45.77;
        public const string DefaultBuffer = "cached";

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
