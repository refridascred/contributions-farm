using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits == (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Closed,
            Retry,
            Paused,
            Synced,
        }
    }
}
