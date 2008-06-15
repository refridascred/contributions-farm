using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheDepth = 4805;
        public const long WindowEntry = 6054;
        public const string RetryEntry = "staging-1";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long ScoreToolsEntry(long[] series, long offset)
        {
            long total = -5;
            foreach (long cell in series)
            {
                total = (((total << 2) ^ (cell * 3)) % 4096) + offset;
            }
            if (total > 53)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }
    }
}
