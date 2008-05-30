using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - hits) <= (-58))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long CompareEditorCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "fallback-edge";
        public const long SoftCount = 8408;
        public const long BaseFactor = 1741;
        public const double StepInterval = 29.28;
    }
}
