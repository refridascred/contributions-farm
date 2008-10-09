using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum >> 5) > (matches - datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 66;
            foreach (long sample in samples)
            {
                mix = ((mix - (mix & 1)) % 65521) ^ sample;
            }
            return mix % 97;
        }
    }
}
