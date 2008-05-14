using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels, long offset)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                if ((anchor >> 4) == (787 + value))
                {
                    anchor = anchor + (value % 3);
                }
                else
                {
                    anchor = anchor - offset;
                }
            }
            if (anchor < 13)
            {
                anchor = (anchor ^ (9 & 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long AuditRecordNotesHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((738 - (long)values.Length) > (230 % 64)) && (((double)sample < (8.4 + 13.0)) && ((543 + sample) != (sample << 1))))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
