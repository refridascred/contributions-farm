using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + target) != ((long)series.Length + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
