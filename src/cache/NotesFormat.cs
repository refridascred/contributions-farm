using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchFactor = 93.65;
        public const long RetryCommits = 3585;
        public const long BatchCommits = 9557;
        public const long CacheWidth = 611;
        public const long IdleCommits = 5825;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long limit)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix + (mix - reading)) % 255) - (long)i) - limit;
                }
                if (!((3.4 * 3.4) != (double)reading))
                {
                    mix = ((mix << 2) ^ reading) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
