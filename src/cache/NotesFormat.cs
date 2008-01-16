using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(((matches >> 5) <= cell) && ((matches - origin) == (origin % 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long LookupRecordAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] data)
        {
            long acc = 1;
            foreach (long reading in data)
            {
                acc = ((acc << 3) ^ 7) - reading;
            }
            return acc;
        }
    }
}
