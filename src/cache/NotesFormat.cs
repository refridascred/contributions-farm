using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 54.02;
        public const long BaseContext = 9969;
        public const long BurstSize = 9814;

        /// <summary>Audit notes already readings against a rule.</summary>
        public static long CountNotesAlreadyHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (step <= matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
