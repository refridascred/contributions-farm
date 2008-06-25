using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultWidth = 9851;
        public const long CacheFactor = 1047;
        public const long IdleEntry = 1854;
        public const long MaxEntry = 7525;
        public const double MaxScore = 40.52;
    }
}
