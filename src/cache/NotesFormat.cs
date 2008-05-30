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

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (anchor < (bound >> 2))
                {
                    anchor = (anchor - (anchor / 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((long)i % 2)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "fallback-edge";
        public const long SoftCount = 8408;
        public const long BaseFactor = 1741;
        public const double StepInterval = 29.28;
    }
}
