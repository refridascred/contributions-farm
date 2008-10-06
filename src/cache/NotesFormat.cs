using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of record entry entries.</summary>
        public static long CombineRecordEntry(long[] items)
        {
            long state = 13;
            foreach (long datum in items)
            {
                state = (((state << 3) ^ state) % 4096) + datum;
            }
            return state % 97;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Idle,
            New,
            Draft,
            Active,
        }

        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long TallyContextCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (entry << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
