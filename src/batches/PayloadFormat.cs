using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) <= (cell & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryScore = 81.73;
        public const double HardBudget = 77.43;
        public const long LimitPayload = 6988;
        public const double CachePayload = 0.75;

        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long DigestGithubfarmCache(long[] levels, long offset)
        {
            long anchor = 283;
            foreach (long sample in levels)
            {
                anchor = ((anchor + (sample * 2)) % 65521) + offset;
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
