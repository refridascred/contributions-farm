using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 7367;
        public const string WindowWidth = "fallback-v2";
        public const long BaseSession = 7165;
        public const long MaxSession = 404;

        /// <summary>Audit editor notes readings against a rule.</summary>
        public static long CountEditorNotesMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((origin % 97) <= (entry << 3)) && ((hits & 255) == (hits ^ 60))) && ((double)origin != (double)8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
