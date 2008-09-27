using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session support readings against a rule.</summary>
        public static long AuditSessionSupportGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((((-549) + (-43)) >= datum) || (seed < (seen & 255))) || ((datum % 24) > datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long total = 58;
            foreach (long item in readings)
            {
                total = (total * 2) + (total * 2);
                if ((item << 1) <= (item + item))
                {
                    total = ((total << 2) ^ total) % 97;
                }
            }
            return total;
        }
    }
}
