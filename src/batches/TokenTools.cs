using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell << 3) > cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches <= 79) && (offset < sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Closed,
            Idle,
            Ready,
            Locked,
        }
    }
}
